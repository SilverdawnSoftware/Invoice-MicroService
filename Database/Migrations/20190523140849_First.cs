using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SilverdawnSoftware.Invoice.Database.Migrations
{
    public partial class First : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Entitys",
                columns: table => new
                {
                    EntityId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    EntityExternalRef = table.Column<string>(nullable: true),
                    AddressAddressId = table.Column<int>(nullable: false),
                    LogoURL = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entitys", x => x.EntityId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    EmalAddress = table.Column<string>(nullable: true),
                    Active = table.Column<bool>(nullable: false),
                    IsCompany = table.Column<bool>(nullable: false),
                    CustomerExteranlRef = table.Column<string>(nullable: true),
                    TaxNo = table.Column<string>(nullable: true),
                    EntityId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                    table.ForeignKey(
                        name: "FK_Customers_Entitys_EntityId",
                        column: x => x.EntityId,
                        principalTable: "Entitys",
                        principalColumn: "EntityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Addresss",
                columns: table => new
                {
                    AddressId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AddressLine1 = table.Column<string>(nullable: true),
                    AddresLine2 = table.Column<string>(nullable: true),
                    City = table.Column<string>(nullable: true),
                    PostZipCode = table.Column<string>(nullable: true),
                    StateCounty = table.Column<string>(nullable: true),
                    Country = table.Column<string>(nullable: true),
                    AddressExternalRef = table.Column<string>(nullable: true),
                    AddressLine3 = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresss", x => x.AddressId);
                    table.ForeignKey(
                        name: "FK_Addresss_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    InvoiceId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    DueDate = table.Column<DateTime>(nullable: false),
                    PaidDate = table.Column<DateTime>(nullable: false),
                    GrandTotal = table.Column<decimal>(nullable: false),
                    SubTotal = table.Column<decimal>(nullable: false),
                    Tax = table.Column<decimal>(nullable: false),
                    OrderedBy = table.Column<string>(nullable: true),
                    PurchaseOrderRef = table.Column<string>(nullable: true),
                    InvoiceNo = table.Column<int>(nullable: false),
                    PaidAmount = table.Column<double>(nullable: false),
                    PaidTax = table.Column<double>(nullable: false),
                    InvoiceEmailed = table.Column<bool>(nullable: false),
                    EmailTo = table.Column<string>(nullable: true),
                    BillngAddressAddressId = table.Column<int>(nullable: false),
                    ShippingAddressAddressId = table.Column<int>(nullable: false),
                    TermsAndConditions = table.Column<string>(nullable: true),
                    PaymentDetails = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    Notes = table.Column<string>(nullable: true),
                    CustomerId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.InvoiceId);
                    table.ForeignKey(
                        name: "FK_Invoices_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvoiceLines",
                columns: table => new
                {
                    InvoiceLineId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<double>(nullable: false),
                    UnitCost = table.Column<decimal>(nullable: false),
                    SubTotal = table.Column<decimal>(nullable: false),
                    TaxTotal = table.Column<decimal>(nullable: false),
                    LineTotal = table.Column<decimal>(nullable: false),
                    Product = table.Column<string>(nullable: true),
                    TaxExempt = table.Column<bool>(nullable: false),
                    ProductCode = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true),
                    InvoiceId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvoiceLines", x => x.InvoiceLineId);
                    table.ForeignKey(
                        name: "FK_InvoiceLines_Invoices_InvoiceId",
                        column: x => x.InvoiceId,
                        principalTable: "Invoices",
                        principalColumn: "InvoiceId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresss_CustomerId",
                table: "Addresss",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Customers_EntityId",
                table: "Customers",
                column: "EntityId");

            migrationBuilder.CreateIndex(
                name: "IX_InvoiceLines_InvoiceId",
                table: "InvoiceLines",
                column: "InvoiceId");

            migrationBuilder.CreateIndex(
                name: "IX_Invoices_CustomerId",
                table: "Invoices",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresss");

            migrationBuilder.DropTable(
                name: "InvoiceLines");

            migrationBuilder.DropTable(
                name: "Invoices");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Entitys");
        }
    }
}
