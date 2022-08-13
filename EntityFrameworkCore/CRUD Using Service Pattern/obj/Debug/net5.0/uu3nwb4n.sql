IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

CREATE TABLE [Brands] (
    [BrandId] bigint NOT NULL IDENTITY,
    [BrandName] nvarchar(max) NULL,
    CONSTRAINT [PK_Brands] PRIMARY KEY ([BrandId])
);
GO

CREATE TABLE [Categories] (
    [CategoryId] bigint NOT NULL IDENTITY,
    [CategoryName] nvarchar(max) NULL,
    CONSTRAINT [PK_Categories] PRIMARY KEY ([CategoryId])
);
GO

CREATE TABLE [Products] (
    [ProductId] bigint NOT NULL IDENTITY,
    [ProductName] nvarchar(max) NULL,
    [Price] decimal(18,2) NULL,
    [DateOfPurchase] datetime2 NULL,
    [AvailabilityStatus] nvarchar(max) NULL,
    [CategoryId] bigint NULL,
    [BrandId] bigint NULL,
    [Active] bit NULL,
    CONSTRAINT [PK_Products] PRIMARY KEY ([ProductId]),
    CONSTRAINT [FK_Products_Brands_BrandId] FOREIGN KEY ([BrandId]) REFERENCES [Brands] ([BrandId]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([CategoryId]) ON DELETE NO ACTION
);
GO

CREATE INDEX [IX_Products_BrandId] ON [Products] ([BrandId]);
GO

CREATE INDEX [IX_Products_CategoryId] ON [Products] ([CategoryId]);
GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20220811055830_IntialMigration', N'5.0.17');
GO

COMMIT;
GO

