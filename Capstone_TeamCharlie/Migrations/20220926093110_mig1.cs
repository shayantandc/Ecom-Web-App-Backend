using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Login.Migrations
{
    public partial class mig1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ECom_Category",
                columns: table => new
                {
                    Category_id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECom_Category", x => x.Category_id);
                });

            migrationBuilder.CreateTable(
                name: "ECom_Login",
                columns: table => new
                {
                    Login_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Password = table.Column<string>(maxLength: 50, nullable: false),
                    Token = table.Column<string>(nullable: false),
                    Date_Time_Stamp = table.Column<DateTime>(type: "datetime", nullable: false),
                    Login_Role = table.Column<string>(unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECom_Login", x => x.Login_Id);
                });

            migrationBuilder.CreateTable(
                name: "ECom_Products",
                columns: table => new
                {
                    Product_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Category_Id = table.Column<int>(nullable: false),
                    Product_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Product_Type = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Product_Price = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    Product_Description = table.Column<string>(unicode: false, maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECom_Products", x => x.Product_Id);
                    table.ForeignKey(
                        name: "FK_ECom_Products_ECom_Category",
                        column: x => x.Category_Id,
                        principalTable: "ECom_Category",
                        principalColumn: "Category_id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ECom_Customers",
                columns: table => new
                {
                    Customer_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Customer_Address = table.Column<string>(maxLength: 150, nullable: false),
                    Customer_Phone_Number = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Customer_Email_Id = table.Column<string>(maxLength: 50, nullable: false),
                    Login_Id = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECom_Customers", x => x.Customer_Id);
                    table.ForeignKey(
                        name: "FK_ECom_Customers_ECom_Login",
                        column: x => x.Login_Id,
                        principalTable: "ECom_Login",
                        principalColumn: "Login_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ECom_Orders",
                columns: table => new
                {
                    Order_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Product_Id = table.Column<int>(nullable: false),
                    Customer_Id = table.Column<int>(nullable: false),
                    Order_Quantity = table.Column<int>(nullable: false),
                    Order_Price = table.Column<decimal>(type: "decimal(18, 0)", nullable: false),
                    Shipment_Address = table.Column<string>(maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECom_Orders", x => x.Order_Id);
                    table.ForeignKey(
                        name: "FK_ECom_Orders_ECom_Customers",
                        column: x => x.Customer_Id,
                        principalTable: "ECom_Customers",
                        principalColumn: "Customer_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ECom_Orders_ECom_Products",
                        column: x => x.Product_Id,
                        principalTable: "ECom_Products",
                        principalColumn: "Product_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ECom_Payment",
                columns: table => new
                {
                    Payment_Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Order_Id = table.Column<int>(nullable: false),
                    Customer_Id = table.Column<int>(nullable: false),
                    Payment_Mode = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Card_Number = table.Column<string>(maxLength: 50, nullable: true),
                    Card_CVV = table.Column<int>(nullable: true),
                    Card_Expiry = table.Column<DateTime>(type: "date", nullable: true),
                    Card_Name = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ECom_Payment", x => x.Payment_Id);
                    table.ForeignKey(
                        name: "FK_ECom_Payment_ECom_Customers",
                        column: x => x.Customer_Id,
                        principalTable: "ECom_Customers",
                        principalColumn: "Customer_Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ECom_Payment_ECom_Orders",
                        column: x => x.Order_Id,
                        principalTable: "ECom_Orders",
                        principalColumn: "Order_Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ECom_Customers_Login_Id",
                table: "ECom_Customers",
                column: "Login_Id");

            migrationBuilder.CreateIndex(
                name: "Login_Id",
                table: "ECom_Login",
                column: "Login_Id",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ECom_Orders_Customer_Id",
                table: "ECom_Orders",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ECom_Orders_Product_Id",
                table: "ECom_Orders",
                column: "Product_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ECom_Payment_Customer_Id",
                table: "ECom_Payment",
                column: "Customer_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ECom_Payment_Order_Id",
                table: "ECom_Payment",
                column: "Order_Id");

            migrationBuilder.CreateIndex(
                name: "IX_ECom_Products_Category_Id",
                table: "ECom_Products",
                column: "Category_Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ECom_Payment");

            migrationBuilder.DropTable(
                name: "ECom_Orders");

            migrationBuilder.DropTable(
                name: "ECom_Customers");

            migrationBuilder.DropTable(
                name: "ECom_Products");

            migrationBuilder.DropTable(
                name: "ECom_Login");

            migrationBuilder.DropTable(
                name: "ECom_Category");
        }
    }
}
