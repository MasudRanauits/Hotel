using Microsoft.EntityFrameworkCore.Migrations;

namespace Hotel_Management.Data.Migrations
{
    public partial class updatepaymenttypetbl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SLId",
                table: "PaymentTypes",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SLId",
                table: "PaymentTypes");
        }
    }
}
