using BibliotecaApi.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

public class DevolucaoMap : IEntityTypeConfiguration<Devolucao>
{
    public void Configure(EntityTypeBuilder<Devolucao> builder)
    {
        builder.ToTable("Devolucao");

        builder.HasKey(d => d.DevolucaoId);

        builder.Property(d => d.DataDevolucao)
            .IsRequired()
            .HasColumnType("datetime")
            .HasDefaultValueSql("CONVERT(datetime, GETDATE())");

        builder.HasOne(d => d.Emprestimo)
            .WithMany(e => e.Devolucoes)
            .HasForeignKey(d => d.EmprestimoId)
            .OnDelete(DeleteBehavior.Cascade);

        
    }
}
