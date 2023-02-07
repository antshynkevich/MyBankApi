using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataEntityAndAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class NewEntities1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtmAddress");

            migrationBuilder.RenameColumn(
                name: "AtmTypeStaticType",
                table: "Atms",
                newName: "AtmTypeId");

            migrationBuilder.AddColumn<int>(
                name: "AtmAvailabilityId",
                table: "Atms",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BaseCurrency",
                table: "Atms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Currency",
                table: "Atms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AtmAddresses",
                columns: table => new
                {
                    AtmId = table.Column<int>(type: "int", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuildingNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TownName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountrySubDivision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtmAddresses", x => x.AtmId);
                    table.ForeignKey(
                        name: "FK_AtmAddresses_Atms_AtmId",
                        column: x => x.AtmId,
                        principalTable: "Atms",
                        principalColumn: "AtmId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AtmBreak",
                columns: table => new
                {
                    AtmBreakId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BreakFromTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    BreakToTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    DayId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtmBreak", x => x.AtmBreakId);
                });

            migrationBuilder.CreateTable(
                name: "AtmService",
                columns: table => new
                {
                    AtmServiceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ServiceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtmService", x => x.AtmServiceId);
                });

            migrationBuilder.CreateTable(
                name: "AtmStandardAvailability",
                columns: table => new
                {
                    AtmStandardAvailabilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AvailabilityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtmStandardAvailability", x => x.AtmStandardAvailabilityId);
                });

            migrationBuilder.CreateTable(
                name: "AtmType",
                columns: table => new
                {
                    AtmTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtmTypeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtmType", x => x.AtmTypeId);
                });

            migrationBuilder.CreateTable(
                name: "CardScheme",
                columns: table => new
                {
                    CardSchemeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CardSchemeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CardScheme", x => x.CardSchemeId);
                });

            migrationBuilder.CreateTable(
                name: "AtmGeolocations",
                columns: table => new
                {
                    AtmAddressAtmId = table.Column<int>(type: "int", nullable: false),
                    AtmId = table.Column<int>(type: "int", nullable: false),
                    AtmGeographicCoordinatesLatitude = table.Column<decimal>(name: "AtmGeographicCoordinates_Latitude", type: "decimal(18,2)", nullable: false),
                    AtmGeographicCoordinatesLongitude = table.Column<decimal>(name: "AtmGeographicCoordinates_Longitude", type: "decimal(18,2)", nullable: false),
                    AtmGeographicCoordinatesGeolocationId = table.Column<int>(name: "AtmGeographicCoordinates_GeolocationId", type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtmGeolocations", x => x.AtmAddressAtmId);
                    table.ForeignKey(
                        name: "FK_AtmGeolocations_AtmAddresses_AtmAddressAtmId",
                        column: x => x.AtmAddressAtmId,
                        principalTable: "AtmAddresses",
                        principalColumn: "AtmId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AtmAtmService",
                columns: table => new
                {
                    AtmServicesAtmServiceId = table.Column<int>(type: "int", nullable: false),
                    AtmsAtmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtmAtmService", x => new { x.AtmServicesAtmServiceId, x.AtmsAtmId });
                    table.ForeignKey(
                        name: "FK_AtmAtmService_AtmService_AtmServicesAtmServiceId",
                        column: x => x.AtmServicesAtmServiceId,
                        principalTable: "AtmService",
                        principalColumn: "AtmServiceId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtmAtmService_Atms_AtmsAtmId",
                        column: x => x.AtmsAtmId,
                        principalTable: "Atms",
                        principalColumn: "AtmId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AtmAvailability",
                columns: table => new
                {
                    AtmAvailabilityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Access24Hours = table.Column<bool>(type: "bit", nullable: false),
                    IsRestricted = table.Column<bool>(type: "bit", nullable: false),
                    SameAsOrganization = table.Column<bool>(type: "bit", nullable: false),
                    AtmStandardAvailabilityId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtmAvailability", x => x.AtmAvailabilityId);
                    table.ForeignKey(
                        name: "FK_AtmAvailability_AtmStandardAvailability_AtmStandardAvailabilityId",
                        column: x => x.AtmStandardAvailabilityId,
                        principalTable: "AtmStandardAvailability",
                        principalColumn: "AtmStandardAvailabilityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AtmDay",
                columns: table => new
                {
                    AtmDayId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DayCode = table.Column<int>(type: "int", nullable: false),
                    OpeningTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    ClosingTime = table.Column<TimeSpan>(type: "time", nullable: true),
                    AtmBreakId = table.Column<int>(type: "int", nullable: false),
                    AtmStandardAvailabilityId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtmDay", x => x.AtmDayId);
                    table.ForeignKey(
                        name: "FK_AtmDay_AtmBreak_AtmBreakId",
                        column: x => x.AtmBreakId,
                        principalTable: "AtmBreak",
                        principalColumn: "AtmBreakId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtmDay_AtmStandardAvailability_AtmStandardAvailabilityId",
                        column: x => x.AtmStandardAvailabilityId,
                        principalTable: "AtmStandardAvailability",
                        principalColumn: "AtmStandardAvailabilityId");
                });

            migrationBuilder.CreateTable(
                name: "AtmCardScheme",
                columns: table => new
                {
                    AtmCardSchemesCardSchemeId = table.Column<int>(type: "int", nullable: false),
                    AtmsAtmId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtmCardScheme", x => new { x.AtmCardSchemesCardSchemeId, x.AtmsAtmId });
                    table.ForeignKey(
                        name: "FK_AtmCardScheme_Atms_AtmsAtmId",
                        column: x => x.AtmsAtmId,
                        principalTable: "Atms",
                        principalColumn: "AtmId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AtmCardScheme_CardScheme_AtmCardSchemesCardSchemeId",
                        column: x => x.AtmCardSchemesCardSchemeId,
                        principalTable: "CardScheme",
                        principalColumn: "CardSchemeId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atms_AtmAvailabilityId",
                table: "Atms",
                column: "AtmAvailabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Atms_AtmTypeId",
                table: "Atms",
                column: "AtmTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_AtmAtmService_AtmsAtmId",
                table: "AtmAtmService",
                column: "AtmsAtmId");

            migrationBuilder.CreateIndex(
                name: "IX_AtmAvailability_AtmStandardAvailabilityId",
                table: "AtmAvailability",
                column: "AtmStandardAvailabilityId");

            migrationBuilder.CreateIndex(
                name: "IX_AtmCardScheme_AtmsAtmId",
                table: "AtmCardScheme",
                column: "AtmsAtmId");

            migrationBuilder.CreateIndex(
                name: "IX_AtmDay_AtmBreakId",
                table: "AtmDay",
                column: "AtmBreakId");

            migrationBuilder.CreateIndex(
                name: "IX_AtmDay_AtmStandardAvailabilityId",
                table: "AtmDay",
                column: "AtmStandardAvailabilityId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atms_AtmAvailability_AtmAvailabilityId",
                table: "Atms",
                column: "AtmAvailabilityId",
                principalTable: "AtmAvailability",
                principalColumn: "AtmAvailabilityId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Atms_AtmType_AtmTypeId",
                table: "Atms",
                column: "AtmTypeId",
                principalTable: "AtmType",
                principalColumn: "AtmTypeId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atms_AtmAvailability_AtmAvailabilityId",
                table: "Atms");

            migrationBuilder.DropForeignKey(
                name: "FK_Atms_AtmType_AtmTypeId",
                table: "Atms");

            migrationBuilder.DropTable(
                name: "AtmAtmService");

            migrationBuilder.DropTable(
                name: "AtmAvailability");

            migrationBuilder.DropTable(
                name: "AtmCardScheme");

            migrationBuilder.DropTable(
                name: "AtmDay");

            migrationBuilder.DropTable(
                name: "AtmGeolocations");

            migrationBuilder.DropTable(
                name: "AtmType");

            migrationBuilder.DropTable(
                name: "AtmService");

            migrationBuilder.DropTable(
                name: "CardScheme");

            migrationBuilder.DropTable(
                name: "AtmBreak");

            migrationBuilder.DropTable(
                name: "AtmStandardAvailability");

            migrationBuilder.DropTable(
                name: "AtmAddresses");

            migrationBuilder.DropIndex(
                name: "IX_Atms_AtmAvailabilityId",
                table: "Atms");

            migrationBuilder.DropIndex(
                name: "IX_Atms_AtmTypeId",
                table: "Atms");

            migrationBuilder.DropColumn(
                name: "AtmAvailabilityId",
                table: "Atms");

            migrationBuilder.DropColumn(
                name: "BaseCurrency",
                table: "Atms");

            migrationBuilder.DropColumn(
                name: "Currency",
                table: "Atms");

            migrationBuilder.RenameColumn(
                name: "AtmTypeId",
                table: "Atms",
                newName: "AtmTypeStaticType");

            migrationBuilder.CreateTable(
                name: "AtmAddress",
                columns: table => new
                {
                    AtmAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtmId = table.Column<int>(type: "int", nullable: false),
                    BuildingNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountrySubDivision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TownName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtmAddress", x => x.AtmAddressId);
                    table.ForeignKey(
                        name: "FK_AtmAddress_Atms_AtmId",
                        column: x => x.AtmId,
                        principalTable: "Atms",
                        principalColumn: "AtmId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtmAddress_AtmId",
                table: "AtmAddress",
                column: "AtmId",
                unique: true);
        }
    }
}
