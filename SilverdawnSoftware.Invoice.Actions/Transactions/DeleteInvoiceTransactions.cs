// ALLOWOVERWRITE-29C946470E88837C2D69F38A487A5A4D
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.Database;
namespace SilverdawnSoftware.Invoice.CQRS.Commands
{
  	public partial class DeleteInvoiceTransations
    {
      public async Task<CQRSBase> CreateInvoice(Models.DeleteInvoice deleteInvoice)
      {
          var result=new CQRSBase();
			try
          {
              using (var db=new InvoiceContext())
              {
                   if (db.Invoices.Any(w =>  w.InvoiceId == deleteInvoice.InvoiceId))
                   {
                       var invoice = db.Invoices.First(w =>  w.InvoiceId == deleteInvoice.InvoiceId);
                       db.Invoices.Remove(invoice);
                       await db.SaveChangesAsync();

                      result.__CQRSSuccessful=true; 
						return result;
                   }
                   else
                   {
                    result.__CQRSSuccessful=false;
                    result.__CQRSErrorMessage="Invoice was not found";
                   }
               }
           }
           catch (Exception e)
               {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    result.__CQRSExceptionMessage=e.Message;
                    result.__CQRSExceptionStackTrace=e.StackTrace;
                    result.__CQRSSuccessful=false;
                }  
                return result;      
           }
	}



}
