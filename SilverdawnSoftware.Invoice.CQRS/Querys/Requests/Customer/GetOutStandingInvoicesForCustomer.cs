// ALLOWOVERWRITE-34C7591D911FDEA31E084404D7BFEB23

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer;
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Database;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Customer
{
    public partial class GetOutStandingInvoicesForCustomerRequest : Orleans.Grain , IGetOutStandingInvoicesForCustomerRequest
    {
   		public async Task<List<IInvoiceView>> GetOutStandingInvoicesForCustomer(IGetOutStandingInvoicesForCustomer getOutStandingInvoicesForCustomer)
   		{
            var result=new List<IInvoiceView>();
             try
               {
                using (var db=new InvoiceContext())
                   {	            
                      var invoices = await db.Invoices.Where(w=> w.Customer.CustomerId == getOutStandingInvoicesForCustomer.CustomerId &&  w.PaidAmount < getOutStandingInvoicesForCustomer.PaidAmount).ToListAsync();
		             	foreach(var invoice in invoices)
				     	{
				      		var toAdd=new InvoiceView();
                            toAdd.CreatedDate=invoice.CreatedDate;
                            toAdd.DueDate=invoice.DueDate;
                            toAdd.EmailTo=invoice.EmailTo;
                            toAdd.GrandTotal=invoice.GrandTotal;
                            toAdd.InvoiceEmailed=invoice.InvoiceEmailed;
                            toAdd.InvoiceId=invoice.InvoiceId;
                            toAdd.InvoiceNo=invoice.InvoiceNo;
                            toAdd.OrderedBy=invoice.OrderedBy;
                            toAdd.PaidAmount=invoice.PaidAmount;
                            toAdd.PaidDate=invoice.PaidDate;
                            toAdd.PaidTax=invoice.PaidTax;
                            toAdd.PaymentDetails=invoice.PaymentDetails;
                            toAdd.PurchaseOrderRef=invoice.PurchaseOrderRef;
                            toAdd.SubTotal=invoice.SubTotal;
                            toAdd.Tax=invoice.Tax;
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




