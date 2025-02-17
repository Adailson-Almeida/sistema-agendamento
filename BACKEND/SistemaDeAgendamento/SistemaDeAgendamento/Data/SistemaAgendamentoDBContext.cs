using Microsoft.EntityFrameworkCore;
using SistemaDeAgendamento.Models;

namespace SistemaDeAgendamento.Data
{
    public class SistemaAgendamentoDBContext : DbContext
    {
        public SistemaAgendamentoDBContext(DbContextOptions<SistemaAgendamentoDBContext> options)
            : base(options)
        {
            
        }

        public DbSet<UsuarioModel> Usuarios { get; set; }
        public DbSet<AgendamentoModel> Agendamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
