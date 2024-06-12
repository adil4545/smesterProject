using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tour_and_travel.Migrations
{
    /// <inheritdoc />
    public partial class upda : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tour",
                table: "tour");

            migrationBuilder.DropColumn(
                name: "uname",
                table: "tour");

            migrationBuilder.RenameColumn(
                name: "upass",
                table: "tour",
                newName: "cpass");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "tour",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<string>(
                name: "cname",
                table: "tour",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tour",
                table: "tour",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_tour",
                table: "tour");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "tour");

            migrationBuilder.DropColumn(
                name: "cname",
                table: "tour");

            migrationBuilder.RenameColumn(
                name: "cpass",
                table: "tour",
                newName: "upass");

            migrationBuilder.AddColumn<string>(
                name: "uname",
                table: "tour",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tour",
                table: "tour",
                column: "uname");
        }
    }
}
