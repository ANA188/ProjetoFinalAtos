                                                             Projeto Final- Academia.Net Atos  

 

 

Proposta: 

 

A proposta é realizar um sistema de empréstimo de livros para uma biblioteca universitária. Nesse sistema, há a implementação de cadastros de livros, estudantes(leitores), 

empréstimos e devoluções. 

 

Tecnologias Utilizadas  

 

 

.Net  

 

É uma plataforma de aplicativos gratuita e de código aberto com suporte da Microsoft e funcionamento multiplataforma. 

 

 

.Visual Studio 

 

Visual Studio é um ambiente de desenvolvimento integrado (IDE) que fornece ferramentas de produtividade de desenvolvimento e recursos de depuração. 

 

 

.Web API  

 

Camada repository: Responsável pelo acesso a dados, pelos métodos 

. 

Camada Model: Responsável pelo mapeamento das colunas das tabelas do banco de dados. 

 

Camada Controller: Recebe solicitações HTTP,processa dados, chama o repository. 

 

Camada Mappins: Faz parte do Entity Framework, mapeia as tabelas do banco de dados, seus relacionamentos,as suas limitações(constraints), suas  chaves primárias e estrangeiras e tipos de dados. 

 

Camada Data: Armazena o contexto(dbContext). 

 

 

C# 

 

É a linguagem de programação mais popular da plataforma .Net, é  fortemente tipada e segue o paradigma de Orientação a Objetos.O C# é uma linguagem de uso geral multiplataforma que torna os desenvolvedores produtivos ao escrever um código de alto desempenho. 

 

 

.Entity Framework  

 

Foi utilizado para permitir a conexão e o mapeamento do banco de dados relacional utilizado. 

 

.SQL Server Microsoft SQL Server 2022 (RTM-GDR) (KB5042211) - 16.0.1125.1 (X64)    

 

Foi utilizado o banco de dados relacional SQL Server, onde foi criado o bando de dados Biblioteca com as seguintes tabelas: 

 

Livro: Armazena as informações necessárias para o cadastro de um livro (Titulo,Autor,Quantidade…) 

 

Leitor: Armazena informações necessárias para o cadastro de leitor (Nome,CPF…) 

 

Emprestimo: Armazena as informações de empréstimos que estão relacionadas ao Livro e ao Leitor. 

 

Devolucao: Armazena as informações de devolução que estão relacionadas ao Emprestimo. 

 

Além disso, esse banco possui dois Triggers : 

 

AtualizarQuantidadeLivro: Diminui a “Quantidade Disponível” de livros (-1 livro) quando um empréstimo ocorre. 

 

AtualizarQuantidadeLivroNaDevolucao: Aumenta a “Quantidade Disponível” de livros (+1 livro) quando ocorre uma devolução. 

 

 

.Windows Forms 

 

Foi utilizado o Windows Forms .Net Framework para a criação da interface gráfica. O Winforms foi conectado ao banco de dados por meio da Web API. 

 

obs: Devido a problemas técnicos não foi possível utilizar o Web Forms. 

 

 

. Newtonsoft.Json. 

 

Pacote utilizado para serializar e desserializar objetos .Net. 

 

 

.RestSharp 

 

Pacote utilizado para consumir a Web API. 

 

 

 
