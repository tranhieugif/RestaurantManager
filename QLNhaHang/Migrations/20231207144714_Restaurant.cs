using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace QLNhaHang.Migrations
{
    /// <inheritdoc />
    public partial class Restaurant : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CustomerName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Address = table.Column<string>(type: "TEXT", nullable: false),
                    number = table.Column<string>(type: "TEXT", nullable: false),
                    email = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategory",
                columns: table => new
                {
                    CategoryID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    FoodType = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategory", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Table",
                columns: table => new
                {
                    TableID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    TableNumber = table.Column<string>(type: "TEXT", nullable: false),
                    status = table.Column<string>(type: "TEXT", nullable: false),
                    ReservedTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NumberOfSeat = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Table", x => x.TableID);
                });

            migrationBuilder.CreateTable(
                name: "Food",
                columns: table => new
                {
                    FoodID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Price = table.Column<long>(type: "INTEGER", nullable: false),
                    AdditionalInFo = table.Column<string>(type: "TEXT", nullable: false),
                    CategoryID = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Food", x => x.FoodID);
                    table.ForeignKey(
                        name: "FK_Food_FoodCategory_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "FoodCategory",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bill",
                columns: table => new
                {
                    Bill_ID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    PaymentDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    TableID = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill", x => x.Bill_ID);
                    table.ForeignKey(
                        name: "FK_Bill_Table_TableID",
                        column: x => x.TableID,
                        principalTable: "Table",
                        principalColumn: "TableID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "BookingTable",
                columns: table => new
                {
                    bookingID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ArrivalTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    NumberOfPeople = table.Column<int>(type: "INTEGER", nullable: false),
                    Status = table.Column<string>(type: "TEXT", nullable: false),
                    TableID = table.Column<long>(type: "INTEGER", nullable: false),
                    CustomerID = table.Column<long>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingTable", x => x.bookingID);
                    table.ForeignKey(
                        name: "FK_BookingTable_Customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingTable_Table_TableID",
                        column: x => x.TableID,
                        principalTable: "Table",
                        principalColumn: "TableID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bill_InFo",
                columns: table => new
                {
                    Bill_InFoID = table.Column<long>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Bill_ID = table.Column<long>(type: "INTEGER", nullable: false),
                    FoodID = table.Column<long>(type: "INTEGER", nullable: false),
                    FoodID1 = table.Column<long>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bill_InFo", x => x.Bill_InFoID);
                    table.ForeignKey(
                        name: "FK_Bill_InFo_Bill_FoodID",
                        column: x => x.FoodID,
                        principalTable: "Bill",
                        principalColumn: "Bill_ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bill_InFo_Food_FoodID1",
                        column: x => x.FoodID1,
                        principalTable: "Food",
                        principalColumn: "FoodID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bill_TableID",
                table: "Bill",
                column: "TableID");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_InFo_FoodID",
                table: "Bill_InFo",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_Bill_InFo_FoodID1",
                table: "Bill_InFo",
                column: "FoodID1");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTable_CustomerID",
                table: "BookingTable",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTable_TableID",
                table: "BookingTable",
                column: "TableID");

            migrationBuilder.CreateIndex(
                name: "IX_Food_CategoryID",
                table: "Food",
                column: "CategoryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bill_InFo");

            migrationBuilder.DropTable(
                name: "BookingTable");

            migrationBuilder.DropTable(
                name: "Bill");

            migrationBuilder.DropTable(
                name: "Food");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Table");

            migrationBuilder.DropTable(
                name: "FoodCategory");
        }
    }
}
