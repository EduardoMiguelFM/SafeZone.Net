using Microsoft.EntityFrameworkCore;
using SafeZone.Domain.Entities;

namespace SafeZone.Infrastructure.Data;

public class SafeZoneContext : DbContext
{
    public SafeZoneContext(DbContextOptions<SafeZoneContext> options) : base(options) { }

    public DbSet<Usuario> Usuarios { get; set; }
    public DbSet<Alerta> Alertas { get; set; }
    public DbSet<Localizacao> Localizacoes { get; set; }
    public DbSet<AreaSegura> AreasSeguras { get; set; }
}