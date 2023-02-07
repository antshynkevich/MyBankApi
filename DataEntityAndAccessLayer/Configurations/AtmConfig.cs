using DataEntityAndAccessLayer.Entities.Atm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataEntityAndAccessLayer.Configurations;

internal class AtmConfig : IEntityTypeConfiguration<Atm>
{
    public void Configure(EntityTypeBuilder<Atm> builder)
    {
        builder.OwnsOne(a => a.AtmAddress)
            .ToTable(nameof(AtmAddress) + "es")
            .OwnsOne(adr => adr.AtmGeolocation)
            .ToTable(nameof(AtmGeolocation) + "s")
            .OwnsOne(g => g.AtmGeographicCoordinates)
            .ToTable(nameof(AtmGeographicCoordinates));
    }
}
