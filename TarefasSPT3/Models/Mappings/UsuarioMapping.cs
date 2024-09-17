using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TarefasSPT3.Models;

public class UsuarioMapping : IEntityTypeConfiguration<Usuario>
{
    public void Configure(EntityTypeBuilder<Usuario> builder)
    {
        builder.ToTable("tb_usuario");

        builder.HasKey(u => u.Id); 
        builder.Property(u => u.Nome)
               .IsRequired()
               .HasMaxLength(100); 

        builder.Property(u => u.Email)
               .IsRequired()
               .HasMaxLength(100);

        builder.Property(u => u.Cpf)
               .IsRequired()
               .HasMaxLength(11);

        builder.Property(u => u.Senha)
               .IsRequired()
               .HasMaxLength(50);

        builder.Property(u => u.Telefone)
               .HasMaxLength(20); 
    }
}