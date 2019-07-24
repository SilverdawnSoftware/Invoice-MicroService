// ALLOWOVERWRITE-4A5411C1749EA16DF1CEB301BD11385C
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
        public DbSet<PaymentHistory> PaymentHistorys { get; set; } 
     }
 }

