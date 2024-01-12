using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNhaHang.Migrations
{
    /// <inheritdoc />
    public partial class Restaurant_7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<float>(
                name: "TotalPrice",
                table: "Bill",
                type: "REAL",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "Bill");
        }
    }
}
