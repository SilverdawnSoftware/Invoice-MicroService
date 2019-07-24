// ALLOWOVERWRITE-10080238FDEB95C35F7395B28B18598A
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


        /// <summary> Add a new invoice to the database </summary>
        /// <param name="invoiceAdd">this is a test</param>
        /// <returns></returns>
        /// <remarks>
        /// ///<div class="Section0"><p style="text-align:left;page-break-inside:auto;page-break-after:auto;page-break-before:avoid;margin-top:0pt;margin-bottom:0pt;margin-left:0pt;text-indent:0pt;margin-right:0pt;"><span lang="en-US" style="color:#000000;font-family:Times New Roman;font-size:12pt;text-transform:none;font-weight:normal;font-style:normal;font-variant:normal;">When creating a new invoice first call this command to create an invoice in the system.</span></p>
///<p style="text-align:left;page-break-inside:auto;page-break-after:auto;page-break-before:avoid;line-height:normal;margin-top:0pt;margin-bottom:0pt;margin-left:0pt;text-indent:0pt;margin-right:0pt;"><span style="color:#000000;font-family:Times New Roman;font-size:12pt;text-transform:none;font-weight:normal;font-style:normal;font-variant:normal;">&#xa0;</span></p>
///<p style="text-align:left;page-break-inside:auto;page-break-after:auto;page-break-before:avoid;margin-top:0pt;margin-bottom:0pt;margin-left:0pt;text-indent:0pt;margin-right:0pt;"><span lang="en-US" style="color:#000000;font-family:Times New Roman;font-size:12pt;text-transform:none;font-weight:normal;font-style:normal;font-variant:normal;">Then once the invoice has been created, Invoices Lines can be added to it</span></p>
///</div>

        /// </remarks>
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
                   //UserCodeBlockStart-PreSave
                    var next = new CounterNextCommand();
                    var nextResult = await next.CounterNext(new CounterNext() { Name = "Invoice" });
                    invoice.InvoiceNo = nextResult.Value;
                   //UserCodeBlockEnd-PreSave

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
          catch (Exception e)
                {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    return new InvoiceView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create InvoiceView",__CQRSStatusCode = 500};             
                } 
           }
	}



}

