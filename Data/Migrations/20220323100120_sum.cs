using Microsoft.EntityFrameworkCore.Migrations;

namespace Course.Data.Migrations
{
    public partial class sum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "sum",
                table: "Review",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "sum",
                table: "Review");
        }
    }
}
