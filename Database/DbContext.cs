// ALLOWOVERWRITE-B1365C769478B88AF5054FB9C65779F9-EFE5A89ECB1A498781D3B9D30EAE97DA
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
        public DbSet<InvoiceLine> InvoiceLines { get; set; } 
        public DbSet<Entity> Entitys { get; set; } 
        public DbSet<Counter> Counters { get; set; } 
     }
 }

