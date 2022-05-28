CREATE TABLE [dbo].[SupplierDetails] (
    [SupplierId]      INT            IDENTITY (1, 1) NOT NULL,
    [SupplierName]    NVARCHAR (50)  NULL,
    [SupplierContact] VARCHAR (50)   NULL,
    [SupplierEmail]   NVARCHAR (255) NULL,
    [created_date]    DATETIME       DEFAULT (getdate()) NOT NULL,
    [modifed_date]    DATETIME       NULL,
    [modifed_by]      DATETIME       NULL,
    [created_by]      DATETIME       DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([SupplierId] ASC)
);

