namespace BibliotecaApi.Models
{
    public class LivroRequest
    {
        public string? Titulo { get; set; }
        public string? Autor { get; set; }
        public string? Categoria { get; set; }
        public int QuantidadeDisponivel { get; set; }

       
    }
}
