// ALLOWOVERWRITE-65A95B61FA53BF0AA1909DE9F9EF7B1E
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.Database;
using SilverdawnSoftware.Invoice.Database;
namespace SilverdawnSoftware.Invoice.CQRS.Commands
{
  	public partial class CreateInvoiceLineTransations
    {
      public async Task<InvoiceView> CreateInvoice(Models.CreateInvoiceLine createInvoiceLine)
      {
			try
          {
              var result=new InvoiceLine();
              using (var db=new InvoiceContext())
              {
                   var invoiceLine = new Database.InvoiceLine();
                   db.InvoiceLines.Add(invoiceLine);
                   invoiceLine.Notes=createInvoiceLine.Notes;
                   invoiceLine.Product=createInvoiceLine.Product;
                   invoiceLine.ProductCode=createInvoiceLine.ProductCode;
                   invoiceLine.Quantity=createInvoiceLine.Quantity;
                   invoiceLine.SubTotal=createInvoiceLine.SubTotal;
                   invoiceLine.TaxExempt=createInvoiceLine.TaxExempt;
                   invoiceLine.TaxTotal=createInvoiceLine.TaxTotal;
                   invoiceLine.UnitCost=createInvoiceLine.UnitCost;
                   await db.SaveChangesAsync();

                   return result;
               }
           }
          catch (Exception e)
                {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    return null;              
                } 
           }
	}



}
