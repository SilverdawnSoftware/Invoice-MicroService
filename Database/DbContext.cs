// ALLOWOVERWRITE-56BADF495C280CB149269CC52C5C1D73
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
        public DbSet<Counter> Counters { get; set; } 
     

	


     }
 }
