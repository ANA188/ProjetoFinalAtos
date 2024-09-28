USE [Biblioteca]
GO

/****** Object:  Table [dbo].[Devolucao]    Script Date: 24/09/2024 11:48:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Devolucao](
	[DevolucaoId] [int] IDENTITY(1,1) NOT NULL,
	[EmprestimoId] [int] NOT NULL,
	[LeitorId] [int] NOT NULL,
	[DataDevolucao] [datetime] NOT NULL,
	[LivroId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[DevolucaoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Devolucao] ADD  CONSTRAINT [DF_DataDevolucao]  DEFAULT (getdate()) FOR [DataDevolucao]
GO

ALTER TABLE [dbo].[Devolucao]  WITH CHECK ADD  CONSTRAINT [FK_Devolucao_Emprestimo] FOREIGN KEY([EmprestimoId])
REFERENCES [dbo].[Emprestimo] ([EmprestimoId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Devolucao] CHECK CONSTRAINT [FK_Devolucao_Emprestimo]
GO

ALTER TABLE [dbo].[Devolucao]  WITH CHECK ADD  CONSTRAINT [FK_Devolucao_Leitor] FOREIGN KEY([LeitorId])
REFERENCES [dbo].[Leitor] ([LeitorId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Devolucao] CHECK CONSTRAINT [FK_Devolucao_Leitor]
GO

ALTER TABLE [dbo].[Devolucao]  WITH CHECK ADD  CONSTRAINT [FK_Devolucao_Livro] FOREIGN KEY([LivroId])
REFERENCES [dbo].[Livro] ([LivroId])
ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Devolucao] CHECK CONSTRAINT [FK_Devolucao_Livro]
GO

