// ALLOWOVERWRITE-4F9F773ECE708B524B4ECC93E59D7F5D
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.InvoiceLine;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.InvoiceLine.Models;
using SilverdawnSoftware.Invoice.Interfaces;
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Database;


namespace SilverdawnSoftware.Invoice.CQRS.Commands.InvoiceLine
{
  	public partial class InvoiceLineUpdateCommand : Orleans.Grain , IInvoiceLineUpdateCommand
    {

		
      public async Task<IInvoiceLineView> InvoiceLineUpdate(IInvoiceLineUpdate invoiceLineUpdate)
      {
			try
          {
              var result=new InvoiceLineView();
              using (var db=new InvoiceContext())
              {
                   if (db.InvoiceLines.Any(w =>  w.InvoiceLineId == invoiceLineUpdate.InvoiceLineId))
                   {
                       var invoiceLine = db.InvoiceLines.First(w =>  w.InvoiceLineId == invoiceLineUpdate.InvoiceLineId);
                    invoiceLine.LineTotal=invoiceLineUpdate.LineTotal;  	
                    invoiceLine.Notes=invoiceLineUpdate.Notes;  	
                    invoiceLine.Product=invoiceLineUpdate.Product;  	
                    invoiceLine.ProductCode=invoiceLineUpdate.ProductCode;  	
                    invoiceLine.Quantity=invoiceLineUpdate.Quantity;  	
                    invoiceLine.SubTotal=invoiceLineUpdate.SubTotal;  	
                    invoiceLine.TaxExempt=invoiceLineUpdate.TaxExempt;  	
                    invoiceLine.TaxTotal=invoiceLineUpdate.TaxTotal;  	
                    invoiceLine.UnitCost=invoiceLineUpdate.UnitCost;  	
                       await db.SaveChangesAsync();

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
               }
           }
              catch (Exception e)
                {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    return new InvoiceLineView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create InvoiceLineView",__CQRSStatusCode = 500};     
                } 
               return null;         
               }
	}



}
