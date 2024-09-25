using BibliotecaApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace BibliotecaApi.Mappings
{


    public class LivroMap : IEntityTypeConfiguration<Livro>
    {
        public void Configure(EntityTypeBuilder<Livro> builder)
        {
            builder.ToTable("Livro");
            builder.HasKey(x => x.LivroId);
           
            builder.Property(x => x.LivroId)
                .HasColumnName("LivroId")
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Titulo)
               .IsRequired()
               .HasMaxLength(255);

            builder.Property(x => x.QuantidadeDisponivel)
                .HasDefaultValue(0);
        }
    }
}
