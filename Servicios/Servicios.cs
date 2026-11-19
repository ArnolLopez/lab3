using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;

namespace Tienda.Core;

public static class PasswordHasher
{
    public static (string Hash, string Salt) Create(string password)
    {
        if (password.Length < 8) throw new ArgumentException("La contraseña debe tener al menos 8 caracteres.");
        var salt = Convert.ToHexString(RandomNumberGenerator.GetBytes(32));
        return (Compute(password, salt), salt);
    }
    private static string Compute(string password, string salt) =>
        Convert.ToHexString(SHA256.HashData(Encoding.UTF8.GetBytes(salt + ":" + password)));
    public static bool Verify(string password, string hash, string salt)
    {
        try
        {
            return CryptographicOperations.FixedTimeEquals(Convert.FromHexString(Compute(password, salt)), Convert.FromHexString(hash));
        }
        catch (FormatException) { return false; }
    }
}

public sealed class AuthService(IRepository<User> users)
{
    private int failures;
    private DateTime blockedUntil;
    public Session Login(string username, string password)
    {
        if (DateTime.UtcNow < blockedUntil)
            throw new ArgumentException("Demasiados intentos. Espera 30 segundos antes de volver a intentar.");
        username = username.Trim().ToLowerInvariant();
        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrEmpty(password))
            throw new ArgumentException("Escribe el usuario y la contraseña.");
        var user = users.Find(u => u.Username == username).SingleOrDefault();
        if (user is null || !user.Active || !PasswordHasher.Verify(password, user.PasswordHash, user.PasswordSalt))
        {
            if (++failures >= 5) { blockedUntil = DateTime.UtcNow.AddSeconds(30); failures = 0; }
            throw new ArgumentException("Usuario o contraseña incorrectos.");
        }
        failures = 0;
        return new Session(user.Id, user.Username, user.FullName);
    }

}

public sealed class ProductService(IRepository<Product> products)
{
    public IReadOnlyList<Product> List(string search = "", bool includeInactive = false) =>
        products.GetAll().Where(p => (includeInactive || p.Active) &&
            (string.IsNullOrWhiteSpace(search) || $"{p.Sku} {p.Name} {p.Category}".Contains(search.Trim(), StringComparison.OrdinalIgnoreCase)))
        .OrderBy(p => p.Name).ToList();

    public void Save(Product product)
    {
        product.Sku = product.Sku.Trim().ToUpperInvariant();
        product.Name = product.Name.Trim();
        product.Category = product.Category.Trim();
        if (!Regex.IsMatch(product.Sku, @"^[A-Z0-9][A-Z0-9_-]{1,24}$"))
            throw new ArgumentException("El código debe tener entre 2 y 25 letras, números, guiones o guiones bajos.");
        if (product.Name.Length is < 2 or > 120) throw new ArgumentException("El nombre debe tener entre 2 y 120 caracteres.");
        if (product.Category.Length is < 2 or > 60) throw new ArgumentException("Escribe una categoría entre 2 y 60 caracteres.");
        if (product.PriceCents <= 0 || product.PriceCents > 100_000_000) throw new ArgumentException("El precio debe ser mayor a cero y menor o igual a $1,000,000.");
        if (product.Stock < 0 || product.Stock > 1_000_000) throw new ArgumentException("Las existencias deben estar entre 0 y 1,000,000.");
        if (products.Find(p => p.Sku == product.Sku).Any(p => p.Id != product.Id))
            throw new ArgumentException("Ya existe un producto con ese código.");
        if (product.Id == 0) product.Id = products.Insert(product); else products.Update(product);
    }

    public void Delete(long id) => products.Delete(id);
}
