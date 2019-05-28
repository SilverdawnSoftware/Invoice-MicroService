// ALLOWOVERWRITE-25C3997B3513677D6E7FC4BE3957A6E4
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.RestAPI;
using SilverdawnSoftware.Invoice.Database;
namespace SilverdawnSoftware.Invoice.CQRS.Commands
{
  	public partial class EmailInvoiceTransations
    {
      public async Task<InvoiceView> CreateInvoice(EmailInvoice emailInvoice)
      {
			try
          {
              var result=new Invoice();
              using (var db=new InvoiceContext())
              {
                   if (db.Invoices.Any(w =>  w.InvoiceId == emailInvoice.InvoiceId))
                   {
                       var invoice = db.Invoices.First(w =>  w.InvoiceId == emailInvoice.InvoiceId);
                       await db.SaveChangesAsync();

                       return result;
                   }
               }
           }
              catch (Exception e)
                {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                         
                } 
               return null;         
               }
	}



}
