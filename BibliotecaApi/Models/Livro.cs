namespace BibliotecaApi.Models
{
    public class Livro
    {
        public int LivroId { get; set; }
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Categoria { get; set; }
        public int QuantidadeDisponivel { get; set; }

        public ICollection<Emprestimo>? Emprestimos { get; set; }

        public Livro() { }
        public Livro(LivroRequest request)
        {
            Titulo = request.Titulo;
            Autor = request.Autor;
            Categoria = request.Categoria;
            QuantidadeDisponivel = request.QuantidadeDisponivel;
            
        }

    }
}
