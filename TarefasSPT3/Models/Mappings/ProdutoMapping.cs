using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TarefasSPT3.Models;

public class ProdutoMapping : IEntityTypeConfiguration<Produto>
{
    public void Configure(EntityTypeBuilder<Produto> builder)
    {
        builder.ToTable("tb_produto");

        builder.HasKey(p => p.Id_produto); 

        builder.Property(p => p.Nome)
               .IsRequired()
               .HasMaxLength(100); 

        builder.Property(p => p.Preco)
               .IsRequired(); 
    }
}