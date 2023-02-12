using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataEntityAndAccessLayer.Migrations
{
    /// <inheritdoc />
    public partial class ContactDetails : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ContactDetails_PhoneNumber",
                table: "Atms",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ContactDetails_PhoneNumber",
                table: "Atms");
        }
    }
}
