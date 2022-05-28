CREATE TABLE [dbo].[UserDetails] (
    [UserId]       INT            IDENTITY (1, 1) NOT NULL,
    [UserName]     NVARCHAR (50)  NULL,
    [Contact]      VARCHAR (50)   NULL,
    [UserAddress]  NVARCHAR (255) NULL,
    [Email]        NVARCHAR (255) NULL,
    [created_date] DATETIME       DEFAULT (getdate()) NOT NULL,
    [modifed_date] DATETIME       NULL,
    [created_by]   DATETIME       DEFAULT (getdate()) NOT NULL,
    [modifed_by]   DATETIME       NULL,
    [UserPassword] NVARCHAR (255) NULL,
    PRIMARY KEY CLUSTERED ([UserId] ASC)
);

