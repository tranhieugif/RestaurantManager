using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNhaHang.Migrations
{
    /// <inheritdoc />
    public partial class Restaurant_2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_InFo_Bill_FoodID",
                table: "Bill_InFo");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_InFo_Food_FoodID1",
                table: "Bill_InFo");

            migrationBuilder.DropIndex(
                name: "IX_Bill_InFo_FoodID1",
                table: "Bill_InFo");

            migrationBuilder.DropColumn(
                name: "FoodID1",
                table: "Bill_InFo");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_InFo_Bill_ID",
                table: "Bill_InFo",
                column: "Bill_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_InFo_Bill_Bill_ID",
                table: "Bill_InFo",
                column: "Bill_ID",
                principalTable: "Bill",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_InFo_Food_FoodID",
                table: "Bill_InFo",
                column: "FoodID",
                principalTable: "Food",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_InFo_Bill_Bill_ID",
                table: "Bill_InFo");

            migrationBuilder.DropForeignKey(
                name: "FK_Bill_InFo_Food_FoodID",
                table: "Bill_InFo");

            migrationBuilder.DropIndex(
                name: "IX_Bill_InFo_Bill_ID",
                table: "Bill_InFo");

            migrationBuilder.AddColumn<long>(
                name: "FoodID1",
                table: "Bill_InFo",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Bill_InFo_FoodID1",
                table: "Bill_InFo",
                column: "FoodID1");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_InFo_Bill_FoodID",
                table: "Bill_InFo",
                column: "FoodID",
                principalTable: "Bill",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_InFo_Food_FoodID1",
                table: "Bill_InFo",
                column: "FoodID1",
                principalTable: "Food",
                principalColumn: "ID");
        }
    }
}
