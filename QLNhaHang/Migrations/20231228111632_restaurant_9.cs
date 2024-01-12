using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNhaHang.Migrations
{
    /// <inheritdoc />
    public partial class restaurant_9 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Account_UserName",
                table: "Bill");

            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Bill",
                newName: "Username");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_UserName",
                table: "Bill",
                newName: "IX_Bill_Username");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Account_Username",
                table: "Bill",
                column: "Username",
                principalTable: "Account",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bill_Account_Username",
                table: "Bill");

            migrationBuilder.RenameColumn(
                name: "Username",
                table: "Bill",
                newName: "UserName");

            migrationBuilder.RenameIndex(
                name: "IX_Bill_Username",
                table: "Bill",
                newName: "IX_Bill_UserName");

            migrationBuilder.AddForeignKey(
                name: "FK_Bill_Account_UserName",
                table: "Bill",
                column: "UserName",
                principalTable: "Account",
                principalColumn: "UserName",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
