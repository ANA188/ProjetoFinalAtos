using BibliotecaApi.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BibliotecaApi.Mappings
{
    public class LeitorMap : IEntityTypeConfiguration<Leitor>
    {
        void IEntityTypeConfiguration<Leitor>.Configure(EntityTypeBuilder<Leitor> builder)
        {
            builder.ToTable("Leitor");

            
            builder.HasKey(x => x.LeitorId);

            builder.Property(x => x.LeitorId)
                .HasColumnName("LeitorId")
                .ValueGeneratedOnAdd()
                .UseIdentityColumn();

            builder.Property(x => x.Nome)
                .IsRequired()
                .HasMaxLength(100); 

            builder.Property(x => x.CPF)
                .IsRequired()
                .HasMaxLength(11); 
            builder.HasIndex(x => x.CPF).IsUnique();

            builder.Property(x => x.Endereco)
                .IsRequired()
                .HasMaxLength(300);

            builder.Property(x => x.Contato)
               .IsRequired()
               .HasMaxLength(50);


            builder.Property(x => x.DataNascimento)
                .IsRequired();


           
        }
    }
}
