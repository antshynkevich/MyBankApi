using DataEntityAndAccessLayer.Entities.Atm;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataEntityAndAccessLayer.Configurations;

internal class AtmTypeConfig : IEntityTypeConfiguration<AtmType>
{
    public void Configure(EntityTypeBuilder<AtmType> builder)
    {
        builder.HasData(
            new { AtmTypeId = 1, AtmTypeName = "ATM", Description = "Банкомат", Atms = new List<Atm>() },
            new { AtmTypeId = 2, AtmTypeName = "PST", Description = "Платежно-справочный терминал", Atms = new List<Atm>() },
            new { AtmTypeId = 3, AtmTypeName = "CASHIN", Description = "Платёжно-справочный терминал с функцией приёма денег", Atms = new List<Atm>() }
        );
    }
}
