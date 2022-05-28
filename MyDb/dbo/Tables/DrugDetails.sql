CREATE TABLE [dbo].[DrugDetails] (
    [DrugId]       INT             IDENTITY (1, 1) NOT NULL,
    [DrugName]     NVARCHAR (50)   NULL,
    [Quantity]     INT             NOT NULL,
    [ExpiryDate]   DATE            NULL,
    [Price]        DECIMAL (10, 2) NULL,
    [SupplierId]   INT             NULL,
    [created_date] DATETIME        DEFAULT (getdate()) NOT NULL,
    [modifed_date] DATETIME        NULL,
    [modifed_by]   DATETIME        NULL,
    [created_by]   DATETIME        DEFAULT (getdate()) NOT NULL,
    PRIMARY KEY CLUSTERED ([DrugId] ASC),
    FOREIGN KEY ([SupplierId]) REFERENCES [dbo].[SupplierDetails] ([SupplierId])
);

