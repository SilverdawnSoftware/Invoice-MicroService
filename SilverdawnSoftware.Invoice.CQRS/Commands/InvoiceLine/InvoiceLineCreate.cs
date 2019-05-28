// ALLOWOVERWRITE-FF62478ADCB27287F922EE204AB53073
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
  	public partial class InvoiceLineCreateCommand : Orleans.Grain , IInvoiceLineCreateCommand
    {

		
      public async Task<IInvoiceLineView> InvoiceLineCreate(IInvoiceLineCreate invoiceLineCreate)
      {
			try
          {
              var result=new InvoiceLineView();
              using (var db=new InvoiceContext())
              {
                   var invoiceLine = new Database.InvoiceLine();
                   if (!db.Invoices.Any(w=>w.InvoiceId == invoiceLineCreate.InvoiceId))				
                       return new InvoiceLineView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to find parent for Invoice",__CQRSStatusCode = 404}; 

                   var invoice=db.Invoices.First(w=>w.InvoiceId == invoiceLineCreate.InvoiceId);				
                   if (invoice.InvoiceLines == null) invoice.InvoiceLines = new List<Database.InvoiceLine>();
                   invoice.InvoiceLines.Add(invoiceLine);
                   invoiceLine.Notes=invoiceLineCreate.Notes;  	
                   invoiceLine.Product=invoiceLineCreate.Product;  	
                   invoiceLine.ProductCode=invoiceLineCreate.ProductCode;  	
                   invoiceLine.Quantity=invoiceLineCreate.Quantity;  	
                   invoiceLine.SubTotal=invoiceLineCreate.SubTotal;  	
                   invoiceLine.TaxExempt=invoiceLineCreate.TaxExempt;  	
                   invoiceLine.TaxTotal=invoiceLineCreate.TaxTotal;  	
                   invoiceLine.UnitCost=invoiceLineCreate.UnitCost;  	
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
          catch (Exception e)
                {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    return new InvoiceLineView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create InvoiceLineView",__CQRSStatusCode = 500};             
                } 
           }
	}



}
