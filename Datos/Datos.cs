using System.Globalization;
using System.Linq.Expressions;
using Microsoft.Data.Sqlite;
using RepoDb;
using Tienda.Core;

namespace Tienda.Core
{
public interface IRepository<T> where T : class, IEntity, new()
{
    IReadOnlyList<T> GetAll();
    T? GetById(long id);
    IReadOnlyList<T> Find(Expression<Func<T, bool>> predicate);
    long Insert(T entity);
    void Update(T entity);
    void Delete(long id);
}

public interface ISalesRepository
{
    Sale Create(long userId, string customer, IReadOnlyList<CartItem> items, DateTime? soldAt = null);
    IReadOnlyList<SaleHistoryRow> History(DateTime from, DateTime through, long? productId = null);
    IReadOnlyList<SaleSummaryRow> Summary(DateTime from, DateTime through, long? productId = null);
    IReadOnlyList<SaleDetail> Details(long saleId);
}
}

namespace Tienda.Infrastructure
{
public sealed class Database
{
    private static readonly object MappingLock = new();
    private static bool mapped;
    public string FilePath { get; }
    public Database(string filePath)
    {
        FilePath = Path.GetFullPath(filePath);
        Directory.CreateDirectory(Path.GetDirectoryName(FilePath)!);
        lock (MappingLock)
        {
            if (mapped) return;
            // SQLite devuelve los booleanos como INTEGER; el handler los convierte al modelo.
            GlobalConfiguration.Setup().UseSqlite();
            FluentMapper.Type<bool>().PropertyHandler<SqliteBooleanHandler>();
            FluentMapper.Entity<User>().Table("Users").Primary(e => e.Id).Identity(e => e.Id);
            FluentMapper.Entity<Product>().Table("Products").Primary(e => e.Id).Identity(e => e.Id);
            FluentMapper.Entity<Sale>().Table("Sales").Primary(e => e.Id).Identity(e => e.Id);
            FluentMapper.Entity<SaleDetail>().Table("SaleDetails").Primary(e => e.Id).Identity(e => e.Id);
            mapped = true;
        }
    }
    public SqliteConnection Open()
    {
        var connection = new SqliteConnection(new SqliteConnectionStringBuilder
        {
            DataSource = FilePath, ForeignKeys = true, DefaultTimeout = 10, Pooling = true
        }.ToString());
        connection.Open();
        return connection;
    }

    public void Initialize(bool demoData = true)
    {
        using var connection = Open();
        var newDatabase = connection.ExecuteScalar<long>("PRAGMA user_version;") == 0;
        connection.ExecuteNonQuery("PRAGMA journal_mode=WAL;");
        using var stream = typeof(Database).Assembly.GetManifestResourceStream("Tienda.Infrastructure.schema.sql")
            ?? throw new InvalidOperationException("No se encontró el esquema de la base de datos.");
        using var reader = new StreamReader(stream);
        using var transaction = connection.BeginTransaction();
        connection.ExecuteNonQuery(reader.ReadToEnd(), transaction: transaction);
        if (connection.CountAll<User>(transaction: transaction) == 0)
        {
            var (hash, salt) = PasswordHasher.Create("123456789");
            connection.Insert<User, long>(new User { Username = "admin", FullName = "Administrador", PasswordHash = hash, PasswordSalt = salt }, transaction: transaction);
        }
        if (demoData && newDatabase)
        {
            var products = new[]
            {
                new Product { Sku="LAP-001", Name="Laptop Lenovo IdeaPad 15", Category="Computadoras", PriceCents=62500, Stock=12 },
                new Product { Sku="MON-001", Name="Monitor Samsung 24 pulgadas", Category="Monitores", PriceCents=15990, Stock=8 },
                new Product { Sku="TEC-001", Name="Teclado mecánico RGB", Category="Periféricos", PriceCents=4550, Stock=20 },
                new Product { Sku="MOU-001", Name="Mouse inalámbrico Logitech", Category="Periféricos", PriceCents=1899, Stock=4 },
                new Product { Sku="AUD-001", Name="Audífonos Bluetooth JBL", Category="Audio", PriceCents=5990, Stock=5 },
                new Product { Sku="SSD-001", Name="SSD Kingston 1 TB", Category="Almacenamiento", PriceCents=7200, Stock=15 },
                new Product { Sku="USB-001", Name="Memoria USB SanDisk 64 GB", Category="Almacenamiento", PriceCents=990, Stock=30 },
                new Product { Sku="WEB-001", Name="Cámara web Full HD", Category="Periféricos", PriceCents=3500, Stock=0 },
                new Product { Sku="HUB-001", Name="Hub USB-C 6 en 1", Category="Accesorios", PriceCents=2990, Stock=3 },
                new Product { Sku="BOC-001", Name="Bocina portátil Bluetooth", Category="Audio", PriceCents=2490, Stock=11 }
            };
            foreach (var product in products) connection.Insert<Product, long>(product, transaction: transaction);
        }
        transaction.Commit();
        if (demoData && newDatabase)
        {
            // Las ventas de ejemplo pasan por las mismas reglas y transacciones que la interfaz.
            var userId = connection.QueryAll<User>().First().Id;
            var products = connection.QueryAll<Product>().ToDictionary(p => p.Sku);
            var sales = new SalesRepository(this);
            sales.Create(userId, "Cliente de demostración", [new(products["LAP-001"].Id, 1), new(products["MOU-001"].Id, 1)], DateTime.Today.AddDays(-2).AddHours(10));
            sales.Create(userId, "Cliente de demostración", [new(products["TEC-001"].Id, 2), new(products["SSD-001"].Id, 1)], DateTime.Today.AddDays(-1).AddHours(14));
            sales.Create(userId, "Cliente de demostración", [new(products["AUD-001"].Id, 2)], DateTime.Today.AddHours(8));
        }
    }
}

public sealed class SqliteBooleanHandler : RepoDb.Interfaces.IPropertyHandler<long, bool>
{
    public bool Get(long input, RepoDb.Options.PropertyHandlerGetOptions options) => input != 0;
    public long Set(bool input, RepoDb.Options.PropertyHandlerSetOptions options) => input ? 1 : 0;
}

public sealed class GenericRepository<T>(Database database) : IRepository<T> where T : class, IEntity, new()
{
    public IReadOnlyList<T> GetAll() { using var c = database.Open(); return c.QueryAll<T>().ToList(); }
    public T? GetById(long id) { using var c = database.Open(); return c.Query<T>(e => e.Id == id).SingleOrDefault(); }
    public IReadOnlyList<T> Find(Expression<Func<T, bool>> predicate) { using var c = database.Open(); return c.Query<T>(predicate).ToList(); }
    public long Insert(T entity)
    {
        try { using var c = database.Open(); return c.Insert<T, long>(entity); }
        catch (SqliteException e) when (typeof(T) == typeof(User) && e.SqliteExtendedErrorCode == 2067)
        { throw new ArgumentException("Ese nombre de usuario ya está registrado. Elige otro.", e); }
        catch (SqliteException e) when (e.SqliteErrorCode == 19) { throw new ArgumentException("No se puede guardar: el código ya existe o los datos no cumplen las reglas de la base de datos.", e); }
    }
    public void Update(T entity)
    {
        try
        {
            using var c = database.Open();
            if (c.Update<T>(entity) != 1) throw new ArgumentException("El registro ya no existe. Actualiza la lista.");
        }
        catch (SqliteException e) when (e.SqliteErrorCode == 19) { throw new ArgumentException("No se puede actualizar: hay un código repetido o datos inválidos.", e); }
    }
    public void Delete(long id)
    {
        try
        {
            using var c = database.Open();
            if (c.Delete<T>(e => e.Id == id) != 1) throw new ArgumentException("El registro ya no existe.");
        }
        catch (SqliteException e) when (e.SqliteErrorCode == 19)
        { throw new ArgumentException("Este producto tiene ventas registradas y debe conservarse. Puedes editarlo y marcarlo como inactivo.", e); }
    }
}

public sealed class SalesRepository(Database database) : ISalesRepository
{
    public Sale Create(long userId, string customer, IReadOnlyList<CartItem> items, DateTime? soldAt = null)
    {
        if (items.Count == 0) throw new ArgumentException("Agrega al menos un producto a la venta.");
        if (items.Any(i => i.Quantity <= 0)) throw new ArgumentException("Todas las cantidades deben ser mayores a cero.");
        customer = string.IsNullOrWhiteSpace(customer) ? "Consumidor final" : customer.Trim();
        if (customer.Length > 120) throw new ArgumentException("El nombre del cliente no debe superar 120 caracteres.");
        var grouped = items.GroupBy(i => i.ProductId).Select(g => new CartItem(g.Key, checked(g.Sum(i => i.Quantity)))).ToList();
        using var c = database.Open();
        // BEGIN IMMEDIATE: reserva la escritura antes de validar y descontar existencias.
        using var tx = c.BeginTransaction(deferred: false);
        var user = c.Query<User>(u => u.Id == userId, transaction: tx).SingleOrDefault();
        if (user is null || !user.Active) throw new ArgumentException("La sesión ya no está disponible.");
        var details = new List<SaleDetail>();
        foreach (var item in grouped)
        {
            var p = c.Query<Product>(p => p.Id == item.ProductId, transaction: tx).SingleOrDefault();
            if (p is null || !p.Active) throw new ArgumentException("Uno de los productos ya no está disponible.");
            if (p.Stock < item.Quantity) throw new ArgumentException($"Stock insuficiente para {p.Name}. Disponible: {p.Stock}.");
            details.Add(new SaleDetail { ProductId = p.Id, Sku = p.Sku, ProductName = p.Name,
                Quantity = item.Quantity, UnitPriceCents = p.PriceCents, SubtotalCents = checked(p.PriceCents * item.Quantity) });
        }
        var sale = new Sale { UserId = userId, Customer = customer,
            SoldAt = (soldAt ?? DateTime.Now).ToString("yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture), TotalCents = checked(details.Sum(d => d.SubtotalCents)) };
        sale.Id = c.Insert<Sale, long>(sale, transaction: tx);
        foreach (var detail in details)
        {
            detail.SaleId = sale.Id;
            c.Insert<SaleDetail, long>(detail, transaction: tx);
            var affected = c.ExecuteNonQuery("UPDATE Products SET Stock = Stock - @Quantity WHERE Id = @ProductId AND Stock >= @Quantity AND Active = 1;",
                new { detail.Quantity, detail.ProductId }, transaction: tx);
            if (affected != 1) throw new ArgumentException("Las existencias cambiaron. Revisa el carrito e intenta otra vez.");
        }
        tx.Commit();
        return sale;
    }

    private static object Parameters(DateTime from, DateTime through, long? productId)
    {
        if (from.Date > through.Date) throw new ArgumentException("La fecha inicial no puede ser posterior a la final.");
        return new { From = from.Date.ToString("yyyy-MM-dd HH:mm:ss"), Until = through.Date.AddDays(1).ToString("yyyy-MM-dd HH:mm:ss"), ProductId = productId };
    }
    public IReadOnlyList<SaleHistoryRow> History(DateTime from, DateTime through, long? productId = null)
    {
        using var c = database.Open();
        return c.ExecuteQuery<SaleHistoryRow>("""
            SELECT s.Id, s.SoldAt, s.Customer, u.FullName AS Seller, s.TotalCents
            FROM Sales s JOIN Users u ON u.Id = s.UserId
            WHERE s.SoldAt >= @From AND s.SoldAt < @Until
              AND (@ProductId IS NULL OR EXISTS(SELECT 1 FROM SaleDetails d WHERE d.SaleId=s.Id AND d.ProductId=@ProductId))
            ORDER BY s.SoldAt DESC, s.Id DESC;
            """, Parameters(from, through, productId)).ToList();
    }
    public IReadOnlyList<SaleSummaryRow> Summary(DateTime from, DateTime through, long? productId = null)
    {
        using var c = database.Open();
        return c.ExecuteQuery<SaleSummaryRow>("""
            SELECT d.ProductId, MAX(d.Sku) AS Sku, MAX(d.ProductName) AS ProductName,
                SUM(d.Quantity) AS Quantity, SUM(d.SubtotalCents) AS AmountCents
            FROM SaleDetails d JOIN Sales s ON s.Id=d.SaleId
            WHERE s.SoldAt >= @From AND s.SoldAt < @Until AND (@ProductId IS NULL OR d.ProductId=@ProductId)
            GROUP BY d.ProductId ORDER BY AmountCents DESC, ProductName;
            """, Parameters(from, through, productId)).ToList();
    }
    public IReadOnlyList<SaleDetail> Details(long saleId)
    { using var c = database.Open(); return c.Query<SaleDetail>(d => d.SaleId == saleId).ToList(); }
}
}
