// ALLOWOVERWRITE-2D7B75483077823EC115C9867300AF88

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
    public partial class GetAllInvoicesForCustomerRequest : Orleans.Grain , IGetAllInvoicesForCustomerRequest
    {
   		public async Task<List<IInvoiceView>> GetAllInvoicesForCustomer(IGetAllInvoicesForCustomer getAllInvoicesForCustomer)
   		{
            var result=new List<IInvoiceView>();
             try
               {
                using (var db=new InvoiceContext())
                   {	            
                      var invoices = await db.Invoices.Where(w=> w.Customer.CustomerId == getAllInvoicesForCustomer.CustomerId).ToListAsync();
		             	foreach(var invoice in invoices)
				     	{
				      		var toAdd=new InvoiceView();
                            toAdd.BillingAddress = new AddressView();
                            toAdd.BillingAddress.AddresLine2=invoice.BillingAddress.AddresLine2;                       			
                            toAdd.BillingAddress.AddressExternalRef=invoice.BillingAddress.AddressExternalRef;                       			
                            toAdd.BillingAddress.AddressLine1=invoice.BillingAddress.AddressLine1;                       			
                            toAdd.BillingAddress.AddressLine3=invoice.BillingAddress.AddressLine3;                       			
                            toAdd.BillingAddress.City=invoice.BillingAddress.City;                       			
                            toAdd.BillingAddress.Country=invoice.BillingAddress.Country;                       			
                            toAdd.BillingAddress.PostZipCode=invoice.BillingAddress.PostZipCode;                       			
                            toAdd.BillingAddress.StateCounty=invoice.BillingAddress.StateCounty;                       			
                            toAdd.CreatedDate=invoice.CreatedDate;
                            toAdd.DueDate=invoice.DueDate;
                            toAdd.EmailTo=invoice.EmailTo;
                            toAdd.GrandTotal=invoice.GrandTotal;
                            toAdd.InvoiceEmailed=invoice.InvoiceEmailed;
                            toAdd.InvoiceId=invoice.InvoiceId;
                            toAdd.InvoiceNo=invoice.InvoiceNo;
                            toAdd.Notes=invoice.Notes;
                            toAdd.OrderedBy=invoice.OrderedBy;
                            toAdd.PaidAmount=invoice.PaidAmount;
                            toAdd.PaidDate=invoice.PaidDate;
                            toAdd.PaidTax=invoice.PaidTax;
                            toAdd.PaymentDetails=invoice.PaymentDetails;
                            toAdd.PurchaseOrderRef=invoice.PurchaseOrderRef;
                            toAdd.ShippingAddress = new AddressView();
                            toAdd.ShippingAddress.AddresLine2=invoice.ShippingAddress.AddresLine2;                       			
                            toAdd.ShippingAddress.AddressExternalRef=invoice.ShippingAddress.AddressExternalRef;                       			
                            toAdd.ShippingAddress.AddressLine1=invoice.ShippingAddress.AddressLine1;                       			
                            toAdd.ShippingAddress.AddressLine3=invoice.ShippingAddress.AddressLine3;                       			
                            toAdd.ShippingAddress.City=invoice.ShippingAddress.City;                       			
                            toAdd.ShippingAddress.Country=invoice.ShippingAddress.Country;                       			
                            toAdd.ShippingAddress.PostZipCode=invoice.ShippingAddress.PostZipCode;                       			
                            toAdd.ShippingAddress.StateCounty=invoice.ShippingAddress.StateCounty;                       			
                            toAdd.Status=invoice.Status;
                            toAdd.SubTotal=invoice.SubTotal;
                            toAdd.Tax=invoice.TaxTotal;
                            toAdd.TermsAndConditions =invoice.TermsAndConditions ;
                            result.Add(toAdd);
						}
	            }
	            return result;
	            }
	            catch (Exception e)
	            {	            
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    result.Clear();
                    return result; 
                   // return new InvoiceView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create InvoiceView",__CQRSStatusCode = 500};             
	            }
   			}
   		
    }    
}




