// ALLOWOVERWRITE-53FD6872AA7A9AE33B01E150F21EA4C2

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice;
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Database;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Invoice
{
    public partial class GetAllOverdueInvoicesForCustomerRequest : Orleans.Grain , IGetAllOverdueInvoicesForCustomerRequest
    {
   		public async  Task<IInvoiceView>  GetAllOverdueInvoicesForCustomer(IGetAllOverdueInvoicesForCustomer getAllOverdueInvoicesForCustomer)
   		{
   			try
	            {
	            var result=new InvoiceView();
	            using (var db=new InvoiceContext())
	            {
	                if (await db.Invoices.AnyAsync(w =>  w.Customer.CustomerId == getAllOverdueInvoicesForCustomer.CustomerId &&  w.DueDate > getAllOverdueInvoicesForCustomer.DueDate &&  w.PaidAmount < getAllOverdueInvoicesForCustomer.PaidAmount))
	                {
	                    var invoice = await db.Invoices.FirstAsync(w =>  w.Customer.CustomerId == getAllOverdueInvoicesForCustomer.CustomerId &&  w.DueDate > getAllOverdueInvoicesForCustomer.DueDate &&  w.PaidAmount < getAllOverdueInvoicesForCustomer.PaidAmount);
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
                    else
                    {
                    return new InvoiceView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to find item",__CQRSStatusCode = 500};                                  
                    }
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




