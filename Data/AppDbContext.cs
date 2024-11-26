using Atividade_07.Models;
using Microsoft.EntityFrameworkCore;

namespace Atividade_07.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Empregador> Empregadores { get; set; }
        public DbSet<Trabalhador> Trabalhadores { get; set; }
        public DbSet<Avaliacao> Avaliacoes { get; set; }
        public DbSet<Servico> Servicos { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }
        public DbSet<Multa> Multas { get; set; }
        public DbSet<Administrador> Administradores { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configurações para Avaliação
            modelBuilder.Entity<Avaliacao>()
                .HasOne(a => a.Autor)
                .WithMany(u => u.Avaliacoes)
                .HasForeignKey("AutorId")
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Avaliacao>()
                .HasOne(a => a.Destinatario)
                .WithMany()
                .HasForeignKey("DestinatarioId")
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
