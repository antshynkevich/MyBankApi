using DataEntityAndAccessLayer.Entities;
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
    }
}
