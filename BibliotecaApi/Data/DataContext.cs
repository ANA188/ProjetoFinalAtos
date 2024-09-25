
using BibliotecaApi.Mappings;
using BibliotecaApi.Models;
using Microsoft.EntityFrameworkCore;

namespace BibliotecaApi.Data
{
    public class DataContext:DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }   

        public DbSet<Livro> Livros { get; set; }
        public DbSet<Leitor> Leitores {  get; set; }
        public DbSet<Emprestimo> Emprestimos { get; set; }
        public DbSet<Devolucao> Devolucoes { get; set; }

       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           modelBuilder.Entity<Emprestimo>(entry =>
            {
                entry.ToTable("Emprestimo", tb => tb.HasTrigger("AtualizarQuantidadeLivro"));
            });
            modelBuilder.Entity<Devolucao>(entry =>
            {
                entry.ToTable("Devolucao", tb => tb.HasTrigger("AtualizarQuantidadeLivroNaDevolucao"));
            });
            //builder.Entity<Emprestimo>().ToTable(Tb => Tb.HasTrigger("AtualizarQuantidadeLivro"));
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.ApplyConfiguration(new LivroMap());
            modelBuilder.ApplyConfiguration(new LeitorMap());
            modelBuilder.ApplyConfiguration(new EmprestimoMap());
           
            modelBuilder.ApplyConfiguration(new DevolucaoMap());


        }

    }
}
