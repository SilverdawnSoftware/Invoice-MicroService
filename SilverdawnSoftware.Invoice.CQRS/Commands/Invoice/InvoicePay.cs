// ALLOWOVERWRITE-F38B7434AC1CF63B68852ECE142A2F3B-130F47E756326E124CFFBCBE13545100
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
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Database;


namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice
{
  	public partial class InvoicePayCommand : Orleans.Grain , IInvoicePayCommand
    {

		
      public async Task<IInvoiceView> InvoicePay(IInvoicePay invoicePay)
      {
			try
          {
              var result=new InvoiceView();
              using (var db=new InvoiceContext())
              {
                   if (db.Invoices.Any(w =>  w.InvoiceId == invoicePay.InvoiceId))
                   {
                       var invoice = db.Invoices.First(w =>  w.InvoiceId == invoicePay.InvoiceId);
                    invoice.PaidAmount=invoicePay.PaidAmount;  	
                    invoice.PaidTax=invoicePay.PaidTax;  	
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
                       result.Tax=invoice.TaxTotal;
                       result.TermsAndConditions =invoice.TermsAndConditions ;
                       return result;
                   }
               }
           }
              catch (Exception e)
                {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    return new InvoiceView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create InvoiceView",__CQRSStatusCode = 500};     
                } 
               return null;         
               }
	}



}
