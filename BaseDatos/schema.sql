-- Tienda Electronica / SQLite. El sistema ejecuta este esquema al primer inicio.
PRAGMA foreign_keys = ON;
CREATE TABLE IF NOT EXISTS Users (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Username TEXT NOT NULL UNIQUE COLLATE NOCASE,
    FullName TEXT NOT NULL,
    PasswordHash TEXT NOT NULL CHECK(length(PasswordHash) = 64),
    PasswordSalt TEXT NOT NULL CHECK(length(PasswordSalt) = 64),
    Active INTEGER NOT NULL DEFAULT 1 CHECK(Active IN (0,1))
);
CREATE TABLE IF NOT EXISTS Products (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    Sku TEXT NOT NULL UNIQUE COLLATE NOCASE,
    Name TEXT NOT NULL,
    Category TEXT NOT NULL,
    PriceCents INTEGER NOT NULL CHECK(PriceCents > 0),
    Stock INTEGER NOT NULL DEFAULT 0 CHECK(Stock >= 0),
    Active INTEGER NOT NULL DEFAULT 1 CHECK(Active IN (0,1))
);
CREATE TABLE IF NOT EXISTS Sales (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    SoldAt TEXT NOT NULL,
    UserId INTEGER NOT NULL REFERENCES Users(Id),
    Customer TEXT NOT NULL,
    TotalCents INTEGER NOT NULL CHECK(TotalCents > 0)
);
CREATE TABLE IF NOT EXISTS SaleDetails (
    Id INTEGER PRIMARY KEY AUTOINCREMENT,
    SaleId INTEGER NOT NULL REFERENCES Sales(Id) ON DELETE RESTRICT,
    ProductId INTEGER NOT NULL REFERENCES Products(Id) ON DELETE RESTRICT,
    ProductName TEXT NOT NULL,
    Sku TEXT NOT NULL,
    Quantity INTEGER NOT NULL CHECK(Quantity > 0),
    UnitPriceCents INTEGER NOT NULL CHECK(UnitPriceCents > 0),
    SubtotalCents INTEGER NOT NULL CHECK(SubtotalCents = Quantity * UnitPriceCents)
);
CREATE INDEX IF NOT EXISTS IX_Sales_SoldAt ON Sales(SoldAt);
CREATE INDEX IF NOT EXISTS IX_SaleDetails_SaleId ON SaleDetails(SaleId);
CREATE INDEX IF NOT EXISTS IX_SaleDetails_ProductId ON SaleDetails(ProductId);
PRAGMA user_version = 1;
