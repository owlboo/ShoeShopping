using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoeShopping.Data.Migrations
{
    public partial class ChangePropertyUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShoppingAddress",
                table: "AspNetUsers",
                newName: "ShippingAddress");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShippingAddress",
                table: "AspNetUsers",
                newName: "ShoppingAddress");
        }
    }
}
