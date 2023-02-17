using DataEntityAndAccessLayer.Entities.Atm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataEntityAndAccessLayer.Configurations;

internal class AtmDayConfig : IEntityTypeConfiguration<AtmDay>
{
    public void Configure(EntityTypeBuilder<AtmDay> builder)
    {
        builder.OwnsOne(a => a.AtmBreak);
    }
}
