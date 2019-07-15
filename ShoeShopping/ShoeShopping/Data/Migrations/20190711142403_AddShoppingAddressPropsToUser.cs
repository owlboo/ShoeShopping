using Microsoft.EntityFrameworkCore.Migrations;

namespace ShoeShopping.Data.Migrations
{
    public partial class AddShoppingAddressPropsToUser : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShoppingAddress",
                table: "AspNetUsers",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShoppingAddress",
                table: "AspNetUsers");
        }
    }
}
