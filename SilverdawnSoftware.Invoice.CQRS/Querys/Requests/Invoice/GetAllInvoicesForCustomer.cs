// ALLOWOVERWRITE-3DB8B28E446F364E577B844DC7CA9560

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




