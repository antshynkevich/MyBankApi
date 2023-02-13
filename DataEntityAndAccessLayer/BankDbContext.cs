using DataEntityAndAccessLayer.Configurations;
using DataEntityAndAccessLayer.Entities.Atm;
using Microsoft.EntityFrameworkCore;

namespace DataEntityAndAccessLayer;

public class BankDbContext : DbContext
{
    public BankDbContext(DbContextOptions<BankDbContext> options) : base(options)
    {
    }

    public DbSet<Atm> Atms { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AtmConfig());
        modelBuilder.ApplyConfiguration(new CardSchemeConfig());
        modelBuilder.ApplyConfiguration(new AtmServiceConfig());
        modelBuilder.ApplyConfiguration(new AtmTypeConfig());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
}
