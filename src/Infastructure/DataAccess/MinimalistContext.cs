using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infastructure.DataAccess;

public class MinimalistContext : DbContext
{
    public MinimalistContext()
    {
        
    }
    public MinimalistContext(DbContextOptions options) : base(options){}

    public DbSet<Item> Items { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
        "data source=DESKTOP-824D8L0;initial catalog=Minimalist Manager;trusted_connection=true;TrustServerCertificate=True");
            base.OnConfiguring(optionsBuilder);
    }
}
