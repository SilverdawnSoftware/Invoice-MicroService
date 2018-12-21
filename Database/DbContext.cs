// ALLOWOVERWRITE-1B0A0323DDDA4F49A2171203D57B7B90
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace SilverdawnSoftware.Invoice.Database
{
    public partial class InvoiceContext : DbContext
    {
    
        public DbSet<Invoice> Invoices { get; set; } 
        public DbSet<Customer> Customers { get; set; } 
        public DbSet<Address> Addresss { get; set; } 
        public DbSet<InvoiceLine> InvoiceLines { get; set; } 
        public DbSet<Entity> Entitys { get; set; } 
     

	


     }
 }