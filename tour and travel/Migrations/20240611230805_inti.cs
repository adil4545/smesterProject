using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace tour_and_travel.Migrations
{
    /// <inheritdoc />
    public partial class inti : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tour",
                columns: table => new
                {
                    uname = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    upass = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tour", x => x.uname);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tour");
        }
    }
}
