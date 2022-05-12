using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Tickets.Data.Migrations
{
    public partial class Serial_number_Add : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Serial_number",
                table: "Segments",
                type: "integer",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Serial_number",
                table: "Segments");
        }
    }
}
