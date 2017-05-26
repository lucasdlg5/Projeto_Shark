CREATE TABLE [dbo].[Table]
(
	[Id_produto] INT NOT NULL PRIMARY KEY, 
	[modelo_produto] VARCHAR(50) NULL,
    [nome_produto] VARCHAR(50) NOT NULL,
	[quantidade_produto] INT NOT NULL,
	[fornecedor_produto] VARCHAR(50) NULL,
	[data_compra_produto] DATETIME NOT NULL,
	[observacoes_produto] VARCHAR (MAX) NOT NULL

)
