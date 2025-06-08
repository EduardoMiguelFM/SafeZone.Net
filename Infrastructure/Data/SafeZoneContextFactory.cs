using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SafeZone.Infrastructure.Data;

public class SafeZoneContextFactory : IDesignTimeDbContextFactory<SafeZoneContext>
{
    public SafeZoneContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<SafeZoneContext>();

        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=safezone_dotnet;Username=postgres;Password=dudu0602");

        return new SafeZoneContext(optionsBuilder.Options);
    }
}
