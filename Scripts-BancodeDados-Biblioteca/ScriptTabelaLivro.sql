USE [Biblioteca]
GO

/****** Object:  Table [dbo].[Livro]    Script Date: 24/09/2024 11:38:31 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Livro](
	[LivroId] [int] IDENTITY(1,1) NOT NULL,
	[Titulo] [nvarchar](255) NOT NULL,
	[Autor] [nvarchar](100) NOT NULL,
	[Categoria] [nvarchar](100) NOT NULL,
	[QuantidadeDisponivel] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[LivroId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Livro]  WITH CHECK ADD CHECK  (([QuantidadeDisponivel]>=(0)))
GO

