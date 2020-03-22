using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace paybook.Migrations
{
    public partial class String : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pay",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    payee = table.Column<int>(nullable: false),
                    money = table.Column<int>(nullable: false),
                    bank = table.Column<int>(nullable: false),
                    payDay = table.Column<string>(nullable: true),
                    payMonth = table.Column<string>(nullable: true),
                    insdate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pay", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pay");
        }
    }
}
