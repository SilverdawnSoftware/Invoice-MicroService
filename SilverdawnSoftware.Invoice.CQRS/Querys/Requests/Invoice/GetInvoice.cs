// ALLOWOVERWRITE-F71B641DD920D5F6E6C5E5ABE0158C63-16D6F37248E2D70C0564C6E21AA13857

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
    public partial class GetInvoiceRequest : Orleans.Grain , IGetInvoiceRequest
    {
   		public async  Task<IInvoiceView>  GetInvoice(IGetInvoice getInvoice)
   		{
   			try
	            {
	            var result=new InvoiceView();
	            using (var db=new InvoiceContext())
	            {
	                if (await db.Invoices.AnyAsync(w =>  w.InvoiceNo == getInvoice.InvoiceNo))
	                {
	                   var invoice = await db.Invoices.FirstAsync(w =>  w.InvoiceNo == getInvoice.InvoiceNo);
                       result.BillingAddress = new AddressView();
                       result.BillingAddress.AddresLine2=invoice.BillingAddress.AddresLine2;                       			
                       result.BillingAddress.AddressExternalRef=invoice.BillingAddress.AddressExternalRef;                       			
                       result.BillingAddress.AddressLine1=invoice.BillingAddress.AddressLine1;                       			
                       result.BillingAddress.AddressLine3=invoice.BillingAddress.AddressLine3;                       			
                       result.BillingAddress.City=invoice.BillingAddress.City;                       			
                       result.BillingAddress.Country=invoice.BillingAddress.Country;                       			
                       result.BillingAddress.PostZipCode=invoice.BillingAddress.PostZipCode;                       			
                       result.BillingAddress.StateCounty=invoice.BillingAddress.StateCounty;                       			
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
                       result.ShippingAddress = new AddressView();
                       result.ShippingAddress.AddresLine2=invoice.ShippingAddress.AddresLine2;                       			
                       result.ShippingAddress.AddressExternalRef=invoice.ShippingAddress.AddressExternalRef;                       			
                       result.ShippingAddress.AddressLine1=invoice.ShippingAddress.AddressLine1;                       			
                       result.ShippingAddress.AddressLine3=invoice.ShippingAddress.AddressLine3;                       			
                       result.ShippingAddress.City=invoice.ShippingAddress.City;                       			
                       result.ShippingAddress.Country=invoice.ShippingAddress.Country;                       			
                       result.ShippingAddress.PostZipCode=invoice.ShippingAddress.PostZipCode;                       			
                       result.ShippingAddress.StateCounty=invoice.ShippingAddress.StateCounty;                       			
                       result.SubTotal=invoice.SubTotal;
                       result.Tax=invoice.TaxTotal;
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




