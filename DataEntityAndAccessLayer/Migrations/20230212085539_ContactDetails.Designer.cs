﻿// <auto-generated />
using System;
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
    [Migration("20230212085539_ContactDetails")]
    partial class ContactDetails
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AtmAtmService", b =>
                {
                    b.Property<int>("AtmServicesAtmServiceId")
                        .HasColumnType("int");

                    b.Property<int>("AtmsAtmId")
                        .HasColumnType("int");

                    b.HasKey("AtmServicesAtmServiceId", "AtmsAtmId");

                    b.HasIndex("AtmsAtmId");

                    b.ToTable("AtmAtmService");
                });

            modelBuilder.Entity("AtmCardScheme", b =>
                {
                    b.Property<int>("AtmCardSchemesCardSchemeId")
                        .HasColumnType("int");

                    b.Property<int>("AtmsAtmId")
                        .HasColumnType("int");

                    b.HasKey("AtmCardSchemesCardSchemeId", "AtmsAtmId");

                    b.HasIndex("AtmsAtmId");

                    b.ToTable("AtmCardScheme");
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.Atm", b =>
                {
                    b.Property<int>("AtmId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtmId"));

                    b.Property<int>("AtmAvailabilityId")
                        .HasColumnType("int");

                    b.Property<int>("AtmTypeId")
                        .HasColumnType("int");

                    b.Property<string>("BaseCurrency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Currency")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AtmId");

                    b.HasIndex("AtmAvailabilityId");

                    b.HasIndex("AtmTypeId");

                    b.ToTable("Atms");
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.AtmAvailability", b =>
                {
                    b.Property<int>("AtmAvailabilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtmAvailabilityId"));

                    b.Property<bool>("Access24Hours")
                        .HasColumnType("bit");

                    b.Property<int>("AtmStandardAvailabilityId")
                        .HasColumnType("int");

                    b.Property<bool>("IsRestricted")
                        .HasColumnType("bit");

                    b.Property<bool>("SameAsOrganization")
                        .HasColumnType("bit");

                    b.HasKey("AtmAvailabilityId");

                    b.HasIndex("AtmStandardAvailabilityId");

                    b.ToTable("AtmAvailability");
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.AtmBreak", b =>
                {
                    b.Property<int>("AtmBreakId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtmBreakId"));

                    b.Property<TimeSpan>("BreakFromTime")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("BreakToTime")
                        .HasColumnType("time");

                    b.Property<int>("DayId")
                        .HasColumnType("int");

                    b.HasKey("AtmBreakId");

                    b.ToTable("AtmBreak");
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.AtmDay", b =>
                {
                    b.Property<int>("AtmDayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtmDayId"));

                    b.Property<int>("AtmBreakId")
                        .HasColumnType("int");

                    b.Property<int?>("AtmStandardAvailabilityId")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("ClosingTime")
                        .HasColumnType("time");

                    b.Property<int>("DayCode")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("OpeningTime")
                        .HasColumnType("time");

                    b.HasKey("AtmDayId");

                    b.HasIndex("AtmBreakId");

                    b.HasIndex("AtmStandardAvailabilityId");

                    b.ToTable("AtmDay");
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.AtmService", b =>
                {
                    b.Property<int>("AtmServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtmServiceId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AtmServiceId");

                    b.ToTable("AtmService");
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.AtmStandardAvailability", b =>
                {
                    b.Property<int>("AtmStandardAvailabilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtmStandardAvailabilityId"));

                    b.Property<int>("AvailabilityId")
                        .HasColumnType("int");

                    b.HasKey("AtmStandardAvailabilityId");

                    b.ToTable("AtmStandardAvailability");
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.AtmType", b =>
                {
                    b.Property<int>("AtmTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtmTypeId"));

                    b.Property<string>("AtmTypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AtmTypeId");

                    b.ToTable("AtmType");
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.CardScheme", b =>
                {
                    b.Property<int>("CardSchemeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CardSchemeId"));

                    b.Property<string>("CardSchemeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CardSchemeId");

                    b.ToTable("CardScheme");
                });

            modelBuilder.Entity("AtmAtmService", b =>
                {
                    b.HasOne("DataEntityAndAccessLayer.Entities.Atm.AtmService", null)
                        .WithMany()
                        .HasForeignKey("AtmServicesAtmServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataEntityAndAccessLayer.Entities.Atm.Atm", null)
                        .WithMany()
                        .HasForeignKey("AtmsAtmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AtmCardScheme", b =>
                {
                    b.HasOne("DataEntityAndAccessLayer.Entities.Atm.CardScheme", null)
                        .WithMany()
                        .HasForeignKey("AtmCardSchemesCardSchemeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataEntityAndAccessLayer.Entities.Atm.Atm", null)
                        .WithMany()
                        .HasForeignKey("AtmsAtmId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.Atm", b =>
                {
                    b.HasOne("DataEntityAndAccessLayer.Entities.Atm.AtmAvailability", "AtmAvailability")
                        .WithMany()
                        .HasForeignKey("AtmAvailabilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataEntityAndAccessLayer.Entities.Atm.AtmType", "AtmType")
                        .WithMany("Atms")
                        .HasForeignKey("AtmTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("DataEntityAndAccessLayer.Entities.Atm.AtmAddress", "AtmAddress", b1 =>
                        {
                            b1.Property<int>("AtmId")
                                .HasColumnType("int");

                            b1.Property<string>("AddressLine")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("BuildingNumber")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Country")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("CountrySubDivision")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("Description")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("StreetName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.Property<string>("TownName")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("AtmId");

                            b1.ToTable("AtmAddresses", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("AtmId");

                            b1.OwnsOne("DataEntityAndAccessLayer.Entities.Atm.AtmGeolocation", "AtmGeolocation", b2 =>
                                {
                                    b2.Property<int>("AtmAddressAtmId")
                                        .HasColumnType("int");

                                    b2.Property<int>("AtmId")
                                        .HasColumnType("int");

                                    b2.HasKey("AtmAddressAtmId");

                                    b2.ToTable("AtmGeolocations", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AtmAddressAtmId");

                                    b2.OwnsOne("DataEntityAndAccessLayer.Entities.Atm.AtmGeographicCoordinates", "AtmGeographicCoordinates", b3 =>
                                        {
                                            b3.Property<int>("AtmGeolocationAtmAddressAtmId")
                                                .HasColumnType("int");

                                            b3.Property<int>("GeolocationId")
                                                .HasColumnType("int");

                                            b3.Property<decimal>("Latitude")
                                                .HasColumnType("decimal(18,2)");

                                            b3.Property<decimal>("Longitude")
                                                .HasColumnType("decimal(18,2)");

                                            b3.HasKey("AtmGeolocationAtmAddressAtmId");

                                            b3.ToTable("AtmGeographicCoordinates", (string)null);

                                            b3.WithOwner()
                                                .HasForeignKey("AtmGeolocationAtmAddressAtmId");
                                        });

                                    b2.Navigation("AtmGeographicCoordinates")
                                        .IsRequired();
                                });

                            b1.Navigation("AtmGeolocation")
                                .IsRequired();
                        });

                    b.OwnsOne("DataEntityAndAccessLayer.Entities.Atm.ContactDetails", "ContactDetails", b1 =>
                        {
                            b1.Property<int>("AtmId")
                                .HasColumnType("int");

                            b1.Property<string>("PhoneNumber")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("AtmId");

                            b1.ToTable("Atms");

                            b1.WithOwner()
                                .HasForeignKey("AtmId");
                        });

                    b.Navigation("AtmAddress")
                        .IsRequired();

                    b.Navigation("AtmAvailability");

                    b.Navigation("AtmType");

                    b.Navigation("ContactDetails")
                        .IsRequired();
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.AtmAvailability", b =>
                {
                    b.HasOne("DataEntityAndAccessLayer.Entities.Atm.AtmStandardAvailability", "AtmStandardAvailability")
                        .WithMany()
                        .HasForeignKey("AtmStandardAvailabilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("AtmStandardAvailability");
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.AtmDay", b =>
                {
                    b.HasOne("DataEntityAndAccessLayer.Entities.Atm.AtmBreak", "AtmBreak")
                        .WithMany()
                        .HasForeignKey("AtmBreakId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataEntityAndAccessLayer.Entities.Atm.AtmStandardAvailability", null)
                        .WithMany("Days")
                        .HasForeignKey("AtmStandardAvailabilityId");

                    b.Navigation("AtmBreak");
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.AtmStandardAvailability", b =>
                {
                    b.Navigation("Days");
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.AtmType", b =>
                {
                    b.Navigation("Atms");
                });
#pragma warning restore 612, 618
        }
    }
}
