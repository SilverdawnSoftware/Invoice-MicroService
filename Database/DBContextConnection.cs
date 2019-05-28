// ALLOWOVERWRITE-D07F3B2F94AD4A846639F4B1B1223481
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;


namespace SilverdawnSoftware.Invoice.Database
{
    public partial class InvoiceContext : DbContext
    {
    
   
	// Delete if not required	
	 protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //IConfigurationRoot configuration = new ConfigurationBuilder()
            //    .AddJsonFile("appsettings.json", optional: true)
            //    .Build();
            //var conn = configuration["ConnectionStrings:DatabaseConnection"];

            //optionsBuilder.UseSqlServer(conn);

           optionsBuilder
               .UseLazyLoadingProxies()
               .UseSqlServer(@"Server=.;Database=InvoiceMicroService;Trusted_Connection=True;MultipleActiveResultSets=true");
        }	


     }
 }