// ALLOWOVERWRITE
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
  	public partial class InvoiceUpdateCommand : Orleans.Grain , IInvoiceUpdateCommand
    {


        /// <summary>  </summary>
        /// <param name="invoiceAdd">this is a test</param>
        /// <returns></returns>
        /// <remarks>
        /// ///

        /// </remarks>
      public async Task<IInvoiceView> InvoiceUpdate(IInvoiceUpdate invoiceUpdate)
      {
			try
          {
              var result=new InvoiceView();
              using (var db=new InvoiceContext())
              {
                   if (db.Invoices.Any(w =>  w.InvoiceId == invoiceUpdate.InvoiceId))
                   {
                       var invoice = db.Invoices.First(w =>  w.InvoiceId == invoiceUpdate.InvoiceId);
                    invoice.CreatedDate=invoiceUpdate.CreatedDate;  	
                    invoice.DueDate=invoiceUpdate.DueDate;  	
                    invoice.EmailTo=invoiceUpdate.EmailTo;  	
                    invoice.GrandTotal=invoiceUpdate.GrandTotal;  	
                    invoice.InvoiceEmailed=invoiceUpdate.InvoiceEmailed;  	
                    invoice.InvoiceNo=invoiceUpdate.InvoiceNo;  	
                    invoice.OrderedBy=invoiceUpdate.OrderedBy;  	
                    invoice.PaidAmount=invoiceUpdate.PaidAmount;  	
                    invoice.PaidDate=invoiceUpdate.PaidDate;  	
                    invoice.PaidTax=invoiceUpdate.PaidTax;  	
                    invoice.PaymentDetails=invoiceUpdate.PaymentDetails;  	
                    invoice.PurchaseOrderRef=invoiceUpdate.PurchaseOrderRef;  	
                    invoice.SubTotal=invoiceUpdate.SubTotal;  	
                    invoice.TaxTotal=invoiceUpdate.TaxTotal;  	
                    invoice.TermsAndConditions =invoiceUpdate.TermsAndConditions ;  	
                       await db.SaveChangesAsync();

                       result.CreatedDate=invoice.CreatedDate;
                       result.DueDate=invoice.DueDate;
                       result.EmailTo=invoice.EmailTo;
                       result.GrandTotal=invoice.GrandTotal;
                       result.InvoiceEmailed=invoice.InvoiceEmailed;
                       result.InvoiceId=invoice.InvoiceId;
                       result.InvoiceNo=invoice.InvoiceNo;
                       result.Notes=invoice.Notes;
                       result.OrderedBy=invoice.OrderedBy;
                       result.PaidAmount=invoice.PaidAmount;
                       result.PaidDate=invoice.PaidDate;
                       result.PaidTax=invoice.PaidTax;
                       result.PaymentDetails=invoice.PaymentDetails;
                       result.PurchaseOrderRef=invoice.PurchaseOrderRef;
                       result.Status=(int)invoice.Status;
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
