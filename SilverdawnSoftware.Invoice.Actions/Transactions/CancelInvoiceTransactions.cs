// ALLOWOVERWRITE-A0E632E1BB8287963554E37B855C017A
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.CQRS.Querys.Models;
using SilverdawnSoftware.Invoice.Database;
namespace SilverdawnSoftware.Invoice.CQRS.Commands
{
  	public partial class CancelInvoiceTransations
    {
      public async Task<InvoiceView> CreateInvoice(CancelInvoice cancelInvoice)
      {
			try
          {
              var result=new InvoiceView();
              using (var db=new InvoiceContext())
              {
                   if (db.Invoices.Any(w =>  w.InvoiceId == cancelInvoice.InvoiceId))
                   {
                       var invoice = db.Invoices.First(w =>  w.InvoiceId == cancelInvoice.InvoiceId);
                       invoice.Notes=cancelInvoice.Reason;
						invoice.Status=InvoiceStatus.Cancelled;
                       await db.SaveChangesAsync();

                       result.CreatedDate=invoice.CreatedDate;
                       result.DueDate=invoice.DueDate;
                       result.EmailTo=invoice.EmailTo;
                       result.GrandTotal=invoice.GrandTotal;
                       result.InvoiceEmailed=invoice.InvoiceEmailed;
                       result.InvoiceId=invoice.InvoiceId;
                       result.InvoiceNo=invoice.InvoiceNo;
                       result.OrderedBy=invoice.OrderedBy;
                       result.PaidAmount=invoice.PaidAmount;
                       result.PaidDate=invoice.PaidDate;
                       result.PaidTax=invoice.PaidTax;
                       result.PaymentDetails=invoice.PaymentDetails;
                       result.PurchaseOrderRef=invoice.PurchaseOrderRef;
                       result.SubTotal=invoice.SubTotal;
                       result.Tax=invoice.Tax;
                       result.TermsAndConditions =invoice.TermsAndConditions ;
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
