// ALLOWOVERWRITE-E24D3207B1FC7FA800579ADE82C58D41
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.CQRS.Commands.Counter;
using SilverdawnSoftware.Invoice.CQRS.Commands.Counter.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;
using SilverdawnSoftware.Invoice.Interfaces;
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Database;


namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice
{
  	public partial class InvoiceAddCommand : Orleans.Grain , IInvoiceAddCommand
    {

		
      public async Task<IInvoiceView> InvoiceAdd(IInvoiceAdd invoiceAdd)
      {
			try
          {
              var result=new InvoiceView();
              using (var db=new InvoiceContext())
              {
                   var invoice = new Database.Invoice();
                   if (!db.Customers.Any(w=>w.CustomerId == invoiceAdd.CustomerId))				
                       return new InvoiceView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to find parent for Customer",__CQRSStatusCode = 404}; 

                   var customer=db.Customers.First(w=>w.CustomerId == invoiceAdd.CustomerId);				
                   if (customer.Invoices == null) customer.Invoices = new List<Database.Invoice>();
                   customer.Invoices.Add(invoice);
                   invoice.CreatedDate=invoiceAdd.CreatedDate;  	
                   invoice.DueDate=invoiceAdd.DueDate;  	
                   invoice.EmailTo=invoiceAdd.EmailTo;  	
                   invoice.OrderedBy=invoiceAdd.OrderedBy;  	
                   invoice.PaymentDetails=invoiceAdd.PaymentDetails;  	
                   invoice.PurchaseOrderRef=invoiceAdd.PurchaseOrderRef;  	
                   invoice.TermsAndConditions =invoiceAdd.TermsAndConditions ;

                    //UserCodeBlockStart-1
                    var next = new CounterNextCommand();
                    var nextResult = await next.CounterNext(new CounterNext() { Name = "Invoice" });
                    invoice.InvoiceNo = nextResult.Value;
                    //UserCodeBlockEnd-1
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
                    return new InvoiceView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create InvoiceView",__CQRSStatusCode = 500};             
                } 
           }
	}



}
