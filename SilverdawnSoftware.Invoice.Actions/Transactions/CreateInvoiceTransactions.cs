// ALLOWOVERWRITE-41D774F9ECFCFE228ECF228D40FF6C89
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
  	public partial class CreateInvoiceTransations
    {
      public async Task<InvoiceView> CreateInvoice(Models.CreateInvoice createInvoice)
      {
			try
          {
              var result=new InvoiceView();
              using (var db=new InvoiceContext())
              {
                   var invoice = new Database.Invoice();
                   db.Invoices.Add(invoice);
                   invoice.CreatedDate=createInvoice.CreatedDate;
                   invoice.DueDate=createInvoice.DueDate;
                   invoice.EmailTo=createInvoice.EmailTo;
                   invoice.OrderedBy=createInvoice.OrderedBy;
                   invoice.PaymentDetails=createInvoice.PaymentDetails;
                   invoice.PurchaseOrderRef=createInvoice.PurchaseOrderRef;
                   invoice.TermsAndConditions =createInvoice.TermsAndConditions ;
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
          catch (Exception e)
                {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    return null;              
                } 
           }
	}



}
