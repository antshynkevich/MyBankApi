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
    public DbSet<AtmType> AtmTypes { get; set; }
    public DbSet<AtmService> AtmServices { get; set; }
    public DbSet<CardScheme> CardSchemes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new AtmConfig());
        modelBuilder.ApplyConfiguration(new CardSchemeConfig());
        modelBuilder.ApplyConfiguration(new AtmServiceConfig());
        modelBuilder.ApplyConfiguration(new AtmTypeConfig());
        modelBuilder.ApplyConfiguration(new AtmDayConfig());
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
    }
}
