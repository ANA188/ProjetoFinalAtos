namespace BibliotecaApi.Models
{
    public class Leitor
    {
        
            public int LeitorId { get; set; }
            public string? Nome { get; set; }
            public string? CPF { get; set; }
            public string? Endereco { get; set; }
            public string? Contato { get; set; }
            public string? DataNascimento { get; set; }

            public ICollection<Emprestimo>? Emprestimos { get; set; }
        
           
        public Leitor() { }

        public Leitor(LeitorRequest request)
        {
           
            Nome = request.Nome;
            CPF = request.CPF;
            Endereco = request.Endereco;   
            Contato = request.Contato;  
            DataNascimento = request.DataNascimento;
        }
        

    }
}
