using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNhaHang.Migrations
{
    /// <inheritdoc />
    public partial class restaurant_8 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserName",
                table: "Bill",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_UserName",
                table: "Bill",
                column: "UserName");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Account_UserName",
                table: "Bill",
                column: "UserName",
                principalTable: "Account",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Account_UserName",
                table: "Bill");

            migrationBuilder.DropIndex(
                name: "IX_Bill_UserName",
                table: "Bill");

            migrationBuilder.DropColumn(
                name: "UserName",
                table: "Bill");
        }
    }
}
