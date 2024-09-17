using Microsoft.EntityFrameworkCore;
using TarefasSPT3.Models;

namespace TarefasSPT3.Data
{
    public class FIAPDBContext : DbContext
    {
        public FIAPDBContext(DbContextOptions<FIAPDBContext> options)
            : base(options)
        {
        }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Formulario> Formularios { get; set; }
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            modelBuilder.ApplyConfiguration(new FormularioMapping());
            modelBuilder.ApplyConfiguration(new ProdutoMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}
