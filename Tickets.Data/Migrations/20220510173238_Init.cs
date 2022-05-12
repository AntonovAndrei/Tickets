using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Tickets.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Segments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Is_passed = table.Column<bool>(type: "boolean", nullable: false),
                    Operation_type = table.Column<string>(type: "text", nullable: false),
                    Operation_time = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Operation_place = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Surname = table.Column<string>(type: "text", nullable: true),
                    Patronymic = table.Column<string>(type: "text", nullable: true),
                    Doc_type = table.Column<int>(type: "integer", nullable: true),
                    Doc_number = table.Column<int>(type: "integer", nullable: true),
                    Birthdate = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Gender = table.Column<string>(type: "text", nullable: true),
                    Passenger_type = table.Column<string>(type: "text", nullable: true),
                    Ticket_number = table.Column<int>(type: "integer", nullable: false),
                    Ticket_type = table.Column<int>(type: "integer", nullable: true),
                    Airline_code = table.Column<string>(type: "text", nullable: true),
                    Flight_num = table.Column<int>(type: "integer", nullable: true),
                    Depart_place = table.Column<string>(type: "text", nullable: true),
                    Depart_datetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Arrive_Place = table.Column<string>(type: "text", nullable: true),
                    Arrive_datetime = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    Pnr_id = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Segments", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Segments");
        }
    }
}
