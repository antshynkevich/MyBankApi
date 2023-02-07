using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataEntityAndAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class NewTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AtmGeographicCoordinates_GeolocationId",
                table: "AtmGeolocations");

            migrationBuilder.DropColumn(
                name: "AtmGeographicCoordinates_Latitude",
                table: "AtmGeolocations");

            migrationBuilder.DropColumn(
                name: "AtmGeographicCoordinates_Longitude",
                table: "AtmGeolocations");

            migrationBuilder.CreateTable(
                name: "AtmGeographicCoordinates",
                columns: table => new
                {
                    AtmGeolocationAtmAddressAtmId = table.Column<int>(type: "int", nullable: false),
                    Latitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Longitude = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    GeolocationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtmGeographicCoordinates", x => x.AtmGeolocationAtmAddressAtmId);
                    table.ForeignKey(
                        name: "FK_AtmGeographicCoordinates_AtmGeolocations_AtmGeolocationAtmAddressAtmId",
                        column: x => x.AtmGeolocationAtmAddressAtmId,
                        principalTable: "AtmGeolocations",
                        principalColumn: "AtmAddressAtmId",
                        onDelete: ReferentialAction.Cascade);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtmGeographicCoordinates");

            migrationBuilder.AddColumn<int>(
                name: "AtmGeographicCoordinates_GeolocationId",
                table: "AtmGeolocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "AtmGeographicCoordinates_Latitude",
                table: "AtmGeolocations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "AtmGeographicCoordinates_Longitude",
                table: "AtmGeolocations",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }
    }
}
