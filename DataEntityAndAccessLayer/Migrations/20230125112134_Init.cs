using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataEntityAndAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Atms",
                columns: table => new
                {
                    AtmId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AtmTypeStaticType = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atms", x => x.AtmId);
                });

            migrationBuilder.CreateTable(
                name: "AtmAddress",
                columns: table => new
                {
                    AtmAddressId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StreetName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BuildingNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TownName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CountrySubDivision = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Code = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddressLine = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AtmId = table.Column<int>(type: "int", nullable: false)
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtmAddress");

            migrationBuilder.DropTable(
                name: "Atms");
        }
    }
}
