using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelFinder.DatabaseContext.Migrations
{
    /// <inheritdoc />
    public partial class FixIdentityColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Hotels");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Hotels",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Id",
                table: "Hotels");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Hotels",
                nullable: false,
                defaultValue: 0);
        }
    }
}
