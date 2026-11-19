-- Base de datos SQLite de demostración para el Laboratorio 3.
-- Usuario: admin | Contraseña: 123456789 (almacenada como hash SHA-256).
-- Ejecutar en una base nueva.
PRAGMA foreign_keys = ON;
BEGIN TRANSACTION;
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

INSERT INTO "Users" VALUES(1,'admin','Administrador','18E68A527FA0AAD26C22B3E6809B2F4935084BFED9E1669D55DF6E9B42E7C54E','48D5A041E6BA7F9FB1A8D2FCBDDFE5FE327291EC6EAEE9B3AF9A74BD859FBC00',1);
INSERT INTO "Products" VALUES(1,'LAP-001','Laptop Lenovo IdeaPad 15','Computadoras',62500,11,1);
INSERT INTO "Products" VALUES(2,'MON-001','Monitor Samsung 24 pulgadas','Monitores',15990,8,1);
INSERT INTO "Products" VALUES(3,'TEC-001','Teclado mecánico RGB','Periféricos',4550,18,1);
INSERT INTO "Products" VALUES(4,'MOU-001','Mouse inalámbrico Logitech','Periféricos',1899,3,1);
INSERT INTO "Products" VALUES(5,'AUD-001','Audífonos Bluetooth JBL','Audio',5990,3,1);
INSERT INTO "Products" VALUES(6,'SSD-001','SSD Kingston 1 TB','Almacenamiento',7200,14,1);
INSERT INTO "Products" VALUES(7,'USB-001','Memoria USB SanDisk 64 GB','Almacenamiento',990,30,1);
INSERT INTO "Products" VALUES(8,'WEB-001','Cámara web Full HD','Periféricos',3500,0,1);
INSERT INTO "Products" VALUES(9,'HUB-001','Hub USB-C 6 en 1','Accesorios',2990,3,1);
INSERT INTO "Products" VALUES(10,'BOC-001','Bocina portátil Bluetooth','Audio',2490,11,1);
INSERT INTO "Sales" VALUES(1,'2026-11-17 10:00:00',1,'Cliente de demostración',64399);
INSERT INTO "Sales" VALUES(2,'2026-11-18 14:00:00',1,'Cliente de demostración',16300);
INSERT INTO "Sales" VALUES(3,'2026-11-19 08:00:00',1,'Cliente de demostración',11980);
INSERT INTO "SaleDetails" VALUES(1,1,1,'Laptop Lenovo IdeaPad 15','LAP-001',1,62500,62500);
INSERT INTO "SaleDetails" VALUES(2,1,4,'Mouse inalámbrico Logitech','MOU-001',1,1899,1899);
INSERT INTO "SaleDetails" VALUES(3,2,3,'Teclado mecánico RGB','TEC-001',2,4550,9100);
INSERT INTO "SaleDetails" VALUES(4,2,6,'SSD Kingston 1 TB','SSD-001',1,7200,7200);
INSERT INTO "SaleDetails" VALUES(5,3,5,'Audífonos Bluetooth JBL','AUD-001',2,5990,11980);
COMMIT;
