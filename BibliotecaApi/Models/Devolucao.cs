namespace BibliotecaApi.Models
{
    public class Devolucao
    {
        public int DevolucaoId { get; set; }
        public int EmprestimoId { get; set; }
        public int LeitorId { get; set; }
        public int LivroId { get; set; }
        public DateTime DataDevolucao { get; set; }
        public virtual Livro Livro { get; set; }
        public virtual Leitor Leitor { get; set; }
        public Emprestimo? Emprestimo { get; set; }
       public Devolucao() 
        {
            
        }

        public Devolucao(DevolucaoRequest request)
        {
           EmprestimoId = request.EmprestimoId;
           LivroId = request.LivroId;
           LeitorId = request.LeitorId;
         





        }
    }
}
