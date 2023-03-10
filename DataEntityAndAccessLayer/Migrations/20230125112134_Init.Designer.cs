// <auto-generated />
using DataEntityAndAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataEntityAndAccessLayer.Migrations
{
    [DbContext(typeof(BankDbContext))]
    [Migration("20230125112134_Init")]
    partial class Init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm", b =>
                {
                    b.Property<int>("AtmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtmId"));

                    b.Property<int>("AtmTypeStaticType")
                        .HasColumnType("int");

                    b.HasKey("AtmId");

                    b.ToTable("Atms");
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.AtmAddress", b =>
                {
                    b.Property<int>("AtmAddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtmAddressId"));

                    b.Property<string>("AddressLine")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("AtmId")
                        .HasColumnType("int");

                    b.Property<string>("BuildingNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CountrySubDivision")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StreetName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TownName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AtmAddressId");

                    b.HasIndex("AtmId")
                        .IsUnique();

                    b.ToTable("AtmAddress");
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.AtmAddress", b =>
                {
                    b.HasOne("DataEntityAndAccessLayer.Entities.Atm", null)
                        .WithOne("AtmAddress")
                        .HasForeignKey("DataEntityAndAccessLayer.Entities.AtmAddress", "AtmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm", b =>
                {
                    b.Navigation("AtmAddress")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
