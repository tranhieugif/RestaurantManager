using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNhaHang.Migrations
{
    /// <inheritdoc />
    public partial class Restaurant_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TableID",
                table: "Table",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "FoodCategory",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "FoodID",
                table: "Food",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "CustomerID",
                table: "Customer",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "bookingID",
                table: "BookingTable",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Bill_InFoID",
                table: "Bill_InFo",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "Bill_ID",
                table: "Bill",
                newName: "ID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Table",
                newName: "TableID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "FoodCategory",
                newName: "CategoryID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Food",
                newName: "FoodID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Customer",
                newName: "CustomerID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "BookingTable",
                newName: "bookingID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Bill_InFo",
                newName: "Bill_InFoID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "Bill",
                newName: "Bill_ID");
        }
    }
}
