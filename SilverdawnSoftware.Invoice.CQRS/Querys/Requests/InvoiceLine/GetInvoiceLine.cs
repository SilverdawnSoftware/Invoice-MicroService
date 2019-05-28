// ALLOWOVERWRITE-8369701088D6095EF99F0F56EA6D836B

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.InvoiceLine.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.InvoiceLine;
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Database;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.InvoiceLine
{
    public partial class GetInvoiceLineRequest : Orleans.Grain , IGetInvoiceLineRequest
    {
   		public async  Task<IInvoiceLineView>  GetInvoiceLine(IGetInvoiceLine getInvoiceLine)
   		{
   			try
	            {
	            var result=new InvoiceLineView();
	            using (var db=new InvoiceContext())
	            {
	                if (await db.InvoiceLines.AnyAsync(w =>  w.InvoiceLineId == getInvoiceLine.InvoiceLineId))
	                {
	                   var invoiceLine = await db.InvoiceLines.FirstAsync(w =>  w.InvoiceLineId == getInvoiceLine.InvoiceLineId);
                       result.InvoiceLineId=invoiceLine.InvoiceLineId;
                       result.LineTotal=invoiceLine.LineTotal;
                       result.Notes=invoiceLine.Notes;
                       result.Product=invoiceLine.Product;
                       result.ProductCode=invoiceLine.ProductCode;
                       result.Quantity=invoiceLine.Quantity;
                       result.SubTotal=invoiceLine.SubTotal;
                       result.TaxExempt=invoiceLine.TaxExempt;
                       result.TaxTotal=invoiceLine.TaxTotal;
                       result.UnitCost=invoiceLine.UnitCost;
				       return result;
	                }
                    else
                    {
                    return new InvoiceLineView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to find item",__CQRSStatusCode = 500};                                  
                    }
	            }
	            }
	            catch (Exception e)
	            {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    return new InvoiceLineView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create InvoiceLineView",__CQRSStatusCode = 500};             
	            }
   			}
   		
    }    
}




