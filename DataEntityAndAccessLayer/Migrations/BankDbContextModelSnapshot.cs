﻿// <auto-generated />
using System;
using DataEntityAndAccessLayer;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataEntityAndAccessLayer.Migrations
{
    [DbContext(typeof(BankDbContext))]
    partial class BankDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
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

                    b.ToTable("AtmAtmService", (string)null);
                });

            modelBuilder.Entity("AtmCardScheme", b =>
                {
                    b.Property<int>("AtmCardSchemesCardSchemeId")
                        .HasColumnType("int");

                    b.Property<int>("AtmsAtmId")
                        .HasColumnType("int");

                    b.HasKey("AtmCardSchemesCardSchemeId", "AtmsAtmId");

                    b.HasIndex("AtmsAtmId");

                    b.ToTable("AtmCardScheme", (string)null);
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

                    b.ToTable("Atms", (string)null);
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.AtmAvailability", b =>
                {
                    b.Property<int>("AtmAvailabilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtmAvailabilityId"));

                    b.Property<bool>("Access24Hours")
                        .HasColumnType("bit");

                    b.Property<bool>("IsRestricted")
                        .HasColumnType("bit");

                    b.Property<bool>("SameAsOrganization")
                        .HasColumnType("bit");

                    b.HasKey("AtmAvailabilityId");

                    b.ToTable("AtmAvailability", (string)null);
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.AtmDay", b =>
                {
                    b.Property<int>("AtmDayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtmDayId"));

                    b.Property<int>("AtmStandardAvailabilityId")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("ClosingTime")
                        .HasColumnType("time");

                    b.Property<int>("DayCode")
                        .HasColumnType("int");

                    b.Property<TimeSpan?>("OpeningTime")
                        .HasColumnType("time");

                    b.HasKey("AtmDayId");

                    b.HasIndex("AtmStandardAvailabilityId");

                    b.ToTable("AtmDays", (string)null);
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

                    b.Property<string>("DescriptionEng")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ServiceName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AtmServiceId");

                    b.ToTable("AtmServices", (string)null);

                    b.HasData(
                        new
                        {
                            AtmServiceId = 1,
                            Description = "Оплата услуг мобильных операторов",
                            DescriptionEng = "Payment for the services of mobile operators",
                            ServiceName = "PaymentMobileServices"
                        },
                        new
                        {
                            AtmServiceId = 2,
                            Description = "Выдача наличных",
                            DescriptionEng = "Cash withdrawal",
                            ServiceName = "CashWithdrawal"
                        },
                        new
                        {
                            AtmServiceId = 3,
                            Description = "Изменение PIN-кода",
                            DescriptionEng = "Change PIN",
                            ServiceName = "PINChange"
                        },
                        new
                        {
                            AtmServiceId = 4,
                            Description = "Разблокировка ПИН",
                            DescriptionEng = "Unlock PIN",
                            ServiceName = "PINUnblock"
                        },
                        new
                        {
                            AtmServiceId = 5,
                            Description = "Активация  ПИН",
                            DescriptionEng = "PIN activation",
                            ServiceName = "PINActivation"
                        },
                        new
                        {
                            AtmServiceId = 6,
                            Description = "Перевод с карты на карту",
                            DescriptionEng = "Transfer from card to card",
                            ServiceName = "Transfer"
                        },
                        new
                        {
                            AtmServiceId = 7,
                            Description = "Получение наличных по коду без использования карты",
                            DescriptionEng = "Getting cash by code without using a card",
                            ServiceName = "CashByCode"
                        },
                        new
                        {
                            AtmServiceId = 8,
                            Description = "Просмотр баланса",
                            DescriptionEng = "Balance view",
                            ServiceName = "Balance"
                        },
                        new
                        {
                            AtmServiceId = 9,
                            Description = "Выписка",
                            DescriptionEng = "Statement",
                            ServiceName = "MiniStatement"
                        },
                        new
                        {
                            AtmServiceId = 10,
                            Description = "Платежи",
                            DescriptionEng = "Payments",
                            ServiceName = "BillPayments"
                        },
                        new
                        {
                            AtmServiceId = 11,
                            Description = "Регистрация мобильного банка",
                            DescriptionEng = "Mobile bank registration",
                            ServiceName = "MobileBankingRegistration"
                        },
                        new
                        {
                            AtmServiceId = 12,
                            Description = "Обмен валют",
                            DescriptionEng = "Currency exchange",
                            ServiceName = "CurrencyExhange"
                        },
                        new
                        {
                            AtmServiceId = 13,
                            Description = "Пополнение наличными",
                            DescriptionEng = "Cash replenishment",
                            ServiceName = "CashIn"
                        },
                        new
                        {
                            AtmServiceId = 14,
                            Description = "Безналичные платежи",
                            DescriptionEng = "Cashless payments",
                            ServiceName = "CashlessPayments"
                        },
                        new
                        {
                            AtmServiceId = 15,
                            Description = "Платежи наличными",
                            DescriptionEng = "Cash payments",
                            ServiceName = "CashPayments"
                        },
                        new
                        {
                            AtmServiceId = 16,
                            Description = "Прием наличных",
                            DescriptionEng = "Cash acceptance",
                            ServiceName = "CashAcceptance"
                        },
                        new
                        {
                            AtmServiceId = 17,
                            Description = "Обмен валюты",
                            DescriptionEng = "Currency exchange",
                            ServiceName = "CurrencyExchange"
                        },
                        new
                        {
                            AtmServiceId = 18,
                            Description = "Прием выручки",
                            DescriptionEng = "Acceptance of proceeds",
                            ServiceName = "AcceptanceProceeds"
                        },
                        new
                        {
                            AtmServiceId = 19,
                            Description = "Бесконтактное cнятие наличных",
                            DescriptionEng = "Contactless cash withdrawal",
                            ServiceName = "ContactlessWithdrawal"
                        },
                        new
                        {
                            AtmServiceId = 20,
                            Description = "Другие",
                            DescriptionEng = "Others",
                            ServiceName = "Other"
                        });
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.AtmStandardAvailability", b =>
                {
                    b.Property<int>("AtmStandardAvailabilityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("AtmStandardAvailabilityId"));

                    b.Property<int>("AtmAvailabilityId")
                        .HasColumnType("int");

                    b.HasKey("AtmStandardAvailabilityId");

                    b.HasIndex("AtmAvailabilityId")
                        .IsUnique();

                    b.ToTable("AtmStandardAvailability", (string)null);
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

                    b.ToTable("AtmTypes", (string)null);

                    b.HasData(
                        new
                        {
                            AtmTypeId = 1,
                            AtmTypeName = "ATM",
                            Description = "Банкомат"
                        },
                        new
                        {
                            AtmTypeId = 2,
                            AtmTypeName = "PST",
                            Description = "Платежно-справочный терминал"
                        },
                        new
                        {
                            AtmTypeId = 3,
                            AtmTypeName = "CASHIN",
                            Description = "Платёжно-справочный терминал с функцией приёма денег"
                        });
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

                    b.Property<string>("DescriptionEng")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CardSchemeId");

                    b.ToTable("CardSchemes", (string)null);

                    b.HasData(
                        new
                        {
                            CardSchemeId = 1,
                            CardSchemeName = "AmericanExpress",
                            Description = "Международная платежная система",
                            DescriptionEng = "International payment system"
                        },
                        new
                        {
                            CardSchemeId = 2,
                            CardSchemeName = "Diners",
                            Description = "Международная платежная система",
                            DescriptionEng = "International payment system"
                        },
                        new
                        {
                            CardSchemeId = 3,
                            CardSchemeName = "Discover",
                            Description = "Международная платежная система",
                            DescriptionEng = "International payment system"
                        },
                        new
                        {
                            CardSchemeId = 4,
                            CardSchemeName = "MasterCard",
                            Description = "Международная платежная система",
                            DescriptionEng = "International payment system"
                        },
                        new
                        {
                            CardSchemeId = 6,
                            CardSchemeName = "Visa",
                            Description = "Международная платежная система",
                            DescriptionEng = "International payment system"
                        },
                        new
                        {
                            CardSchemeId = 7,
                            CardSchemeName = "МИР",
                            Description = "Российская национальная платежная система",
                            DescriptionEng = "Russian National Payment System"
                        },
                        new
                        {
                            CardSchemeId = 8,
                            CardSchemeName = "ArCa",
                            Description = "Армянская национальная платежная система",
                            DescriptionEng = "Armenian National Payment System"
                        },
                        new
                        {
                            CardSchemeId = 9,
                            CardSchemeName = "БЕЛКАРТ",
                            Description = "Белорусская национальная платежная система",
                            DescriptionEng = "Belarusian National Payment System"
                        },
                        new
                        {
                            CardSchemeId = 10,
                            CardSchemeName = "ELCART",
                            Description = "Киргизская национальная платежная система",
                            DescriptionEng = "Kyrgyz National Payment System"
                        },
                        new
                        {
                            CardSchemeId = 11,
                            CardSchemeName = "JCB",
                            Description = "Крупнейшая платежная система Японии и одна из пяти ведущих платежных систем мира",
                            DescriptionEng = "Japan National Payment System"
                        },
                        new
                        {
                            CardSchemeId = 12,
                            CardSchemeName = "UPI",
                            Description = "Национальная платежная система Китая",
                            DescriptionEng = "China National Payment System"
                        });
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

                    b.OwnsOne("DataEntityAndAccessLayer.Entities.Atm.Atm.AtmAddress#DataEntityAndAccessLayer.Entities.Atm.AtmAddress", "AtmAddress", b1 =>
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

                            b1.OwnsOne("DataEntityAndAccessLayer.Entities.Atm.Atm.AtmAddress#DataEntityAndAccessLayer.Entities.Atm.AtmAddress.AtmGeolocation#DataEntityAndAccessLayer.Entities.Atm.AtmGeolocation", "AtmGeolocation", b2 =>
                                {
                                    b2.Property<int>("AtmAddressAtmId")
                                        .HasColumnType("int");

                                    b2.HasKey("AtmAddressAtmId");

                                    b2.ToTable("AtmGeolocations", (string)null);

                                    b2.WithOwner()
                                        .HasForeignKey("AtmAddressAtmId");

                                    b2.OwnsOne("DataEntityAndAccessLayer.Entities.Atm.Atm.AtmAddress#DataEntityAndAccessLayer.Entities.Atm.AtmAddress.AtmGeolocation#DataEntityAndAccessLayer.Entities.Atm.AtmGeolocation.AtmGeographicCoordinates#DataEntityAndAccessLayer.Entities.Atm.AtmGeographicCoordinates", "AtmGeographicCoordinates", b3 =>
                                        {
                                            b3.Property<int>("AtmGeolocationAtmAddressAtmId")
                                                .HasColumnType("int");

                                            b3.Property<decimal>("Latitude")
                                                .HasColumnType("decimal(8,6)");

                                            b3.Property<decimal>("Longitude")
                                                .HasColumnType("decimal(8,6)");

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

                    b.OwnsOne("DataEntityAndAccessLayer.Entities.Atm.Atm.ContactDetails#DataEntityAndAccessLayer.Entities.Atm.ContactDetails", "ContactDetails", b1 =>
                        {
                            b1.Property<int>("AtmId")
                                .HasColumnType("int");

                            b1.Property<string>("PhoneNumber")
                                .IsRequired()
                                .HasColumnType("nvarchar(max)");

                            b1.HasKey("AtmId");

                            b1.ToTable("Atms", (string)null);

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

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.AtmDay", b =>
                {
                    b.HasOne("DataEntityAndAccessLayer.Entities.Atm.AtmStandardAvailability", null)
                        .WithMany("Days")
                        .HasForeignKey("AtmStandardAvailabilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.OwnsOne("DataEntityAndAccessLayer.Entities.Atm.AtmDay.AtmBreak#DataEntityAndAccessLayer.Entities.Atm.AtmBreak", "AtmBreak", b1 =>
                        {
                            b1.Property<int>("AtmDayId")
                                .HasColumnType("int");

                            b1.Property<TimeSpan>("BreakFromTime")
                                .HasColumnType("time");

                            b1.Property<TimeSpan>("BreakToTime")
                                .HasColumnType("time");

                            b1.HasKey("AtmDayId");

                            b1.ToTable("AtmDays", (string)null);

                            b1.WithOwner()
                                .HasForeignKey("AtmDayId");
                        });

                    b.Navigation("AtmBreak")
                        .IsRequired();
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.AtmStandardAvailability", b =>
                {
                    b.HasOne("DataEntityAndAccessLayer.Entities.Atm.AtmAvailability", null)
                        .WithOne("AtmStandardAvailability")
                        .HasForeignKey("DataEntityAndAccessLayer.Entities.Atm.AtmStandardAvailability", "AtmAvailabilityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataEntityAndAccessLayer.Entities.Atm.AtmAvailability", b =>
                {
                    b.Navigation("AtmStandardAvailability")
                        .IsRequired();
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
