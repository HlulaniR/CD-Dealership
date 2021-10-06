CREATE TABLE [dbo].[Employees] (
    [UserID]           INT           NOT NULL,
    [FirstName]    NVARCHAR (30) NULL,
    [LastName]     NVARCHAR (30) NULL,
    [Gender]       NCHAR (1)     NULL,
    [Email]        NVARCHAR (30) NULL,
    [Phone_No] NCHAR (10)    NULL,
    [Address]      NVARCHAR (30) NULL,
    [Position]     NVARCHAR (30) NULL,
    PRIMARY KEY CLUSTERED ([UserID] ASC)
);

