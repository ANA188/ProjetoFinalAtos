using BibliotecaApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BibliotecaApi.Mappings
{
    public class EmprestimoMap : IEntityTypeConfiguration<Emprestimo>
    {
        public void Configure(EntityTypeBuilder<Emprestimo> builder)
        {
            builder.ToTable("Emprestimo");

            
            builder.HasKey(x => x.EmprestimoId);

           
            builder.Property(x => x.DataEmprestimo)
                .IsRequired()
                .HasDefaultValueSql("CONVERT(date, GETDATE())");

            builder.Property(x => x.DataDevolucaoPrevista)
                .IsRequired()
                .HasDefaultValueSql("CONVERT(date, DATEADD(DAY, 14, GETDATE()))"); 

           
             builder.HasOne(x => x.Leitor)
                .WithMany(x => x.Emprestimos)
                .HasForeignKey(x => x.LeitorId)
                .OnDelete(DeleteBehavior.Cascade);

           
            builder.HasOne(x => x.Livro)
                .WithMany(l => l.Emprestimos)
               .HasForeignKey(x => x.LivroId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasMany(e => e.Devolucoes)
                .WithOne(d => d.Emprestimo)
                .HasForeignKey(d => d.EmprestimoId);
        }
    }
    
}
