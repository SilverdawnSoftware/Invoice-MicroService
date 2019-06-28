using Microsoft.EntityFrameworkCore.Migrations;

namespace SilverdawnSoftware.Invoice.Database.Migrations
{
    public partial class taxtotal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tax",
                table: "Invoices",
                newName: "TaxTotal");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TaxTotal",
                table: "Invoices",
                newName: "Tax");
        }
    }
}
