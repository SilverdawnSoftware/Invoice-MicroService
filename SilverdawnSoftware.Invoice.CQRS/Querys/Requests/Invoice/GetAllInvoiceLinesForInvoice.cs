// ALLOWOVERWRITE-49B2AAE718E860925C8193451FDE6444

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
    public partial class GetAllInvoiceLinesForInvoiceRequest : Orleans.Grain , IGetAllInvoiceLinesForInvoiceRequest
    {
   		public async Task<List<IInvoiceLineView>> GetAllInvoiceLinesForInvoice(IGetAllInvoiceLinesForInvoice getAllInvoiceLinesForInvoice)
   		{
            var result=new List<IInvoiceLineView>();
             try
               {
                using (var db=new InvoiceContext())
                   {	            
                      var invoiceLines = await db.InvoiceLines.Where(w=> w.Invoice.InvoiceNo == getAllInvoiceLinesForInvoice.InvoiceNo).ToListAsync();
		             	foreach(var invoiceLine in invoiceLines)
				     	{
				      		var toAdd=new InvoiceLineView();
                            toAdd.InvoiceLineId=invoiceLine.InvoiceLineId;
                            toAdd.LineTotal=invoiceLine.LineTotal;
                            toAdd.Notes=invoiceLine.Notes;
                            toAdd.Product=invoiceLine.Product;
                            toAdd.ProductCode=invoiceLine.ProductCode;
                            toAdd.Quantity=invoiceLine.Quantity;
                            toAdd.SubTotal=invoiceLine.SubTotal;
                            toAdd.TaxExempt=invoiceLine.TaxExempt;
                            toAdd.TaxTotal=invoiceLine.TaxTotal;
                            toAdd.UnitCost=invoiceLine.UnitCost;
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
                   // return new InvoiceLineView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create InvoiceLineView",__CQRSStatusCode = 500};             
	            }
   			}
   		
    }    
}




