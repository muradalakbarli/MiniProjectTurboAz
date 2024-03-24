USE TurboAz

CREATE TABLE Brands (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    CreatedBy NVARCHAR(100) NOT NULL,
    CreatedAt DATETIME NOT NULL,
    LastModifiedBy NVARCHAR(100),
    LastModifiedAt DATETIME,
    DeletedBy NVARCHAR(100),
    DeletedAt DATETIME
);

CREATE TABLE Models (
    Id INT PRIMARY KEY,
    Name NVARCHAR(100) NOT NULL,
    BrandId INT NOT NULL,
    CreatedBy NVARCHAR(100) NOT NULL,
    CreatedAt DATETIME NOT NULL,
    LastModifiedBy NVARCHAR(100),
    LastModifiedAt DATETIME,
    DeletedBy NVARCHAR(100),
    DeletedAt DATETIME,
    FOREIGN KEY (BrandId) REFERENCES Brands(Id)
);

CREATE TABLE Announcements (
    Id INT PRIMARY KEY,
    ModelId INT NOT NULL,
    Category NVARCHAR(100) NOT NULL,
    Gear NVARCHAR(100),
    FuelType NVARCHAR(100),
    Transmissions NVARCHAR(100),
    March NVARCHAR(100),
    Price DECIMAL(18, 2) NOT NULL,
    Year INT NOT NULL,
    CreatedBy NVARCHAR(100) NOT NULL,
    CreatedAt DATETIME NOT NULL,
    LastModifiedBy NVARCHAR(100),
    LastModifiedAt DATETIME,
    DeletedBy NVARCHAR(100),
    DeletedAt DATETIME,
    FOREIGN KEY (ModelId) REFERENCES Models(Id)
);
