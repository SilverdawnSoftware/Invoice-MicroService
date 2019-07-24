// ALLOWOVERWRITE-BCD9BB3A5900C475B476E8328000322C
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;
using SilverdawnSoftware.Invoice.Interfaces;
using SilverdawnSoftware.Invoice.Database;


namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice
{
  	public partial class InvoiceDeleteCommand : Orleans.Grain , IInvoiceDeleteCommand
    {


        /// <summary>  </summary>
        /// <param name="invoiceAdd">this is a test</param>
        /// <returns></returns>
        /// <remarks>
        /// ///

        /// </remarks>
      public async Task<ICQRSBase> InvoiceDelete(IInvoiceDelete invoiceDelete)
      {
          var result=new CQRSBase();
			try
          {
              using (var db=new InvoiceContext())
              {
                   if (db.Invoices.Any(w =>  w.InvoiceId == invoiceDelete.InvoiceId))
                   {
                       var invoice = db.Invoices.First(w =>  w.InvoiceId == invoiceDelete.InvoiceId);
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
                    return new CQRSBase(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to delete Invoice",__CQRSStatusCode = 500};
                }  
                return result;      
           }
	}



}
