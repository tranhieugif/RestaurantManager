using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNhaHang.Migrations
{
    /// <inheritdoc />
    public partial class restaurant_4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingTable");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropColumn(
                name: "NumberOfSeat",
                table: "Table");

            migrationBuilder.DropColumn(
                name: "ReservedTime",
                table: "Table");

            migrationBuilder.DropColumn(
                name: "AdditionalInFo",
                table: "Food");

            migrationBuilder.RenameColumn(
                name: "PaymentDate",
                table: "Bill",
                newName: "DateCheckIn");

            migrationBuilder.AddColumn<int>(
                name: "Count",
                table: "Bill_InFo",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DateCheckOut",
                table: "Bill",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Type",
                table: "Account",
                type: "INTEGER",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "TEXT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Count",
                table: "Bill_InFo");

            migrationBuilder.DropColumn(
                name: "DateCheckOut",
                table: "Bill");

            migrationBuilder.RenameColumn(
                name: "DateCheckIn",
                table: "Bill",
                newName: "PaymentDate");

            migrationBuilder.AddColumn<int>(
                name: "NumberOfSeat",
                table: "Table",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "ReservedTime",
                table: "Table",
                type: "TEXT",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "AdditionalInFo",
                table: "Food",
                type: "TEXT",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Account",
                type: "TEXT",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    CustomerName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false),
                    number = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "BookingTable",
                columns: table => new
                {
                    ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerID = table.Column<long>(type: "INTEGER", nullable: false),
                    TableID = table.Column<long>(type: "INTEGER", nullable: false),
                    ArrivalTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NumberOfPeople = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingTable", x => x.ID);
                    table.ForeignKey(
                        name: "FK_BookingTable_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingTable_Table_TableID",
                        column: x => x.TableID,
                        principalTable: "Table",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingTable_CustomerID",
                table: "BookingTable",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTable_TableID",
                table: "BookingTable",
                column: "TableID");
        }
    }
}
