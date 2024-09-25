using System.Text.Json.Serialization;

namespace BibliotecaApi.Models
{
    public class Emprestimo
    {
        public int EmprestimoId { get; set; }
        public int LeitorId { get; set; }
        public int LivroId { get; set; }
        public DateOnly DataEmprestimo { get; set; }
        public DateOnly DataDevolucaoPrevista { get; set; }

        public ICollection<Devolucao> Devolucoes { get; set; }

         public Leitor? Leitor { get; set; }
         public Livro? Livro { get; set; }
         

        public Emprestimo() { }
        public Emprestimo(EmprestimoRequest request)
        {
           LeitorId = request.LeitorId;
           LivroId = request.LivroId;
          
          
           
           

        }
    }
}
