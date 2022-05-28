CREATE TABLE [dbo].[Orders] (
    [OrderId]      INT      NULL,
    [UserId]       INT      NULL,
    [created_by]   DATETIME DEFAULT (getdate()) NOT NULL,
    [modifed_date] DATETIME NULL,
    [modifed_by]   DATETIME NULL,
    [created_date] DATETIME DEFAULT (getdate()) NOT NULL,
    FOREIGN KEY ([OrderId]) REFERENCES [dbo].[OrderDetails] ([OrderId]),
    FOREIGN KEY ([UserId]) REFERENCES [dbo].[UserDetails] ([UserId])
);

