// ALLOWOVERWRITE-E19D6ABB4F21569DA5BFFBB52E85A0E5
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
  	public partial class InvoiceLineAddCommand : Orleans.Grain , IInvoiceLineAddCommand
    {

		
      public async Task<IInvoiceLineView> InvoiceLineAdd(IInvoiceLineAdd invoiceLineAdd)
      {
			try
          {
              var result=new InvoiceLineView();
              using (var db=new InvoiceContext())
              {
                   var invoiceLine = new Database.InvoiceLine();
                   if (!db.Invoices.Any(w=>w.InvoiceId == invoiceLineAdd.InvoiceId))				
                       return new InvoiceLineView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to find parent for Invoice",__CQRSStatusCode = 404}; 

                   var invoice=db.Invoices.First(w=>w.InvoiceId == invoiceLineAdd.InvoiceId);				
                   if (invoice.InvoiceLines == null) invoice.InvoiceLines = new List<Database.InvoiceLine>();
                   invoice.InvoiceLines.Add(invoiceLine);
                   invoiceLine.LineTotal=invoiceLineAdd.LineTotal;  	
                   invoiceLine.Notes=invoiceLineAdd.Notes;  	
                   invoiceLine.Product=invoiceLineAdd.Product;  	
                   invoiceLine.ProductCode=invoiceLineAdd.ProductCode;  	
                   invoiceLine.Quantity=invoiceLineAdd.Quantity;  	
                   invoiceLine.SubTotal=invoiceLineAdd.SubTotal;  	
                   invoiceLine.TaxExempt=invoiceLineAdd.TaxExempt;  	
                   invoiceLine.TaxTotal=invoiceLineAdd.TaxTotal;  	
                   invoiceLine.UnitCost=invoiceLineAdd.UnitCost;  	
                   //UserCodeBlockStart-PreSave
                   //UserCodeBlockEnd-PreSave
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
                   //UserCodeBlockStart-PreResult
                   //UserCodeBlockEnd-PreResult
                   return result;
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

