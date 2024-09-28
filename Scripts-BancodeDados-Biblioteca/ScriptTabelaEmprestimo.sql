USE [Biblioteca]
GO

/****** Object:  Table [dbo].[Emprestimo]    Script Date: 24/09/2024 11:47:13 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Emprestimo](
	[EmprestimoId] [int] IDENTITY(1,1) NOT NULL,
	[LeitorId] [int] NOT NULL,
	[LivroId] [int] NOT NULL,
	[DataEmprestimo] [date] NOT NULL,
	[DataDevolucaoPrevista] [date] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[EmprestimoId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Emprestimo] ADD  CONSTRAINT [DF_DataEmprestimo]  DEFAULT (CONVERT([date],getdate())) FOR [DataEmprestimo]
GO

ALTER TABLE [dbo].[Emprestimo] ADD  CONSTRAINT [DF_DataDevolucaoPrevista]  DEFAULT (CONVERT([date],dateadd(day,(14),getdate()))) FOR [DataDevolucaoPrevista]
GO

ALTER TABLE [dbo].[Emprestimo]  WITH CHECK ADD FOREIGN KEY([LeitorId])
REFERENCES [dbo].[Leitor] ([LeitorId])
GO

ALTER TABLE [dbo].[Emprestimo]  WITH CHECK ADD FOREIGN KEY([LivroId])
REFERENCES [dbo].[Livro] ([LivroId])
GO

