using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TarefasSPT3.Models;
public class FormularioMapping : IEntityTypeConfiguration<Formulario>
{
    public void Configure(EntityTypeBuilder<Formulario> builder)
    {
        builder.ToTable("tb_formulario"); 

        builder.HasKey(f => f.Id_formulario); 

        builder.Property(f => f.StatusAlergia)
               .IsRequired()
               .HasMaxLength(50); 

        builder.Property(f => f.DescricaoAlergia)
               .HasMaxLength(500); 

        builder.Property(f => f.DescricaoPele)
               .HasMaxLength(500); 
    }
}

