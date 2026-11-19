namespace Tienda.Core;

public interface IEntity { long Id { get; set; } }

public sealed class User : IEntity
{
    public long Id { get; set; }
    public string Username { get; set; } = "";
    public string FullName { get; set; } = "";
    public string PasswordHash { get; set; } = "";
    public string PasswordSalt { get; set; } = "";
    public bool Active { get; set; } = true;
}

public sealed class Product : IEntity
{
    public long Id { get; set; }
    public string Sku { get; set; } = "";
    public string Name { get; set; } = "";
    public string Category { get; set; } = "";
    public long PriceCents { get; set; }
    public int Stock { get; set; }
    public bool Active { get; set; } = true;
}

public sealed class Sale : IEntity
{
    public long Id { get; set; }
    public string SoldAt { get; set; } = "";
    public long UserId { get; set; }
    public string Customer { get; set; } = "Consumidor final";
    public long TotalCents { get; set; }
}

public sealed class SaleDetail : IEntity
{
    public long Id { get; set; }
    public long SaleId { get; set; }
    public long ProductId { get; set; }
    public string ProductName { get; set; } = "";
    public string Sku { get; set; } = "";
    public int Quantity { get; set; }
    public long UnitPriceCents { get; set; }
    public long SubtotalCents { get; set; }
}

public sealed record CartItem(long ProductId, int Quantity);
public sealed class SaleHistoryRow
{
    public long Id { get; set; }
    public string SoldAt { get; set; } = "";
    public string Customer { get; set; } = "";
    public string Seller { get; set; } = "";
    public long TotalCents { get; set; }
}
public sealed class SaleSummaryRow
{
    public long ProductId { get; set; }
    public string Sku { get; set; } = "";
    public string ProductName { get; set; } = "";
    public long Quantity { get; set; }
    public long AmountCents { get; set; }
}
public sealed record Session(long UserId, string Username, string FullName);
