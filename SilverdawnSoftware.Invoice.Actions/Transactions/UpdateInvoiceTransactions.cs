// ALLOWOVERWRITE-6B3C8A67592AC40A5D866693B0815CBE
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
  	public partial class UpdateInvoiceTransations
    {
      public async Task<InvoiceView> CreateInvoice(UpdateInvoice updateInvoice)
      {
			try
          {
              var result=new InvoiceView();
              using (var db=new InvoiceContext())
              {
                   if (db.Invoices.Any(w =>  w.InvoiceId == updateInvoice.InvoiceId))
                   {
                       var invoice = db.Invoices.First(w =>  w.InvoiceId == updateInvoice.InvoiceId);
                       invoice.BillngAddress=updateInvoice.BillngAddress;
                       invoice.CreatedDate=updateInvoice.CreatedDate;
                       invoice.DueDate=updateInvoice.DueDate;
                       invoice.EmailTo=updateInvoice.EmailTo;
                       invoice.GrandTotal=updateInvoice.GrandTotal;
                       invoice.InvoiceEmailed=updateInvoice.InvoiceEmailed;
                       invoice.InvoiceNo=updateInvoice.InvoiceNo;
                       invoice.OrderedBy=updateInvoice.OrderedBy;
                       invoice.PaidAmount=updateInvoice.PaidAmount;
                       invoice.PaidDate=updateInvoice.PaidDate;
                       invoice.PaidTax=updateInvoice.PaidTax;
                       invoice.PaymentDetails=updateInvoice.PaymentDetails;
                       invoice.PurchaseOrderRef=updateInvoice.PurchaseOrderRef;
                       invoice.ShippingAddress=updateInvoice.ShippingAddress;
                       invoice.SubTotal=updateInvoice.SubTotal;
                       invoice.Tax=updateInvoice.Tax;
                       invoice.TermsAndConditions =updateInvoice.TermsAndConditions ;
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
