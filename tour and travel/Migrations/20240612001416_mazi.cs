using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tour_and_travel.Migrations
{
    /// <inheritdoc />
    public partial class mazi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "cpass",
                table: "tour",
                newName: "cdestination");

            migrationBuilder.AddColumn<int>(
                name: "cadult",
                table: "tour",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cbill",
                table: "tour",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cchild",
                table: "tour",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "cstay",
                table: "tour",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "cadult",
                table: "tour");

            migrationBuilder.DropColumn(
                name: "cbill",
                table: "tour");

            migrationBuilder.DropColumn(
                name: "cchild",
                table: "tour");

            migrationBuilder.DropColumn(
                name: "cstay",
                table: "tour");

            migrationBuilder.RenameColumn(
                name: "cdestination",
                table: "tour",
                newName: "cpass");
        }
    }
}
