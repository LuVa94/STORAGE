CREATE TABLE [dbo].[Заказ] (
    [заказID]         INT                IDENTITY (1, 1) NOT NULL,
    [Длина]           INT                NULL,
    [Ширина]          INT                NULL,
    [Глубина]         INT                NULL,
    [материалID]        INT         NULL,
    [Стоимость]       INT                NULL,
    [Дата_выполнения] DATETIMEOFFSET (7) NULL,
    [Статус]          NCHAR (25)         NULL,
    [мебельID]        INT                NULL,
    [клиентID]        INT                NULL,
    CONSTRAINT [PK_Заказ] PRIMARY KEY CLUSTERED ([заказID] ASC),
    CONSTRAINT [FK_Заказ_Мебель] FOREIGN KEY ([мебельID]) REFERENCES [dbo].[Мебель] ([мебельID]),
    CONSTRAINT [FK_Заказ_Клиент] FOREIGN KEY ([клиентID]) REFERENCES [dbo].[Клиент] ([клиентID]), 
    CONSTRAINT [FK_Заказ_Материал] FOREIGN KEY ([материалID]) REFERENCES [Материал]([материалID])
);

