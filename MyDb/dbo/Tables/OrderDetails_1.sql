CREATE TABLE [dbo].[OrderDetails] (
    [OrderId]       INT             IDENTITY (1, 1) NOT NULL,
    [DrugId]        INT             NULL,
    [Quantity]      INT             NULL,
    [TotalAmount]   DECIMAL (10, 2) NULL,
    [created_date]  DATETIME        DEFAULT (getdate()) NOT NULL,
    [modifed_date]  DATETIME        NULL,
    [modifed_by]    DATETIME        NULL,
    [created_by]    DATETIME        DEFAULT (getdate()) NOT NULL,
    [OrderPrice]    DECIMAL (10, 2) NULL,
    [OrderPickedUp] DATE            NULL,
    PRIMARY KEY CLUSTERED ([OrderId] ASC),
    FOREIGN KEY ([DrugId]) REFERENCES [dbo].[DrugDetails] ([DrugId])
);

