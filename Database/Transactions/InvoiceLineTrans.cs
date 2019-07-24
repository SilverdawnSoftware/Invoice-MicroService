// ALLOWOVERWRITE-4A880A9F6D7D572FD5402A8173128499

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.Database.Transactions.Model;
using SilverdawnSoftware.Invoice.Database.Views.Model;
using data = SilverdawnSoftware.Invoice.Database;
namespace SilverdawnSoftware.Invoice.Database.Transactions
{
 public partial class InvoiceLineTransactions
 {
      
 		// Add Transaction Code
 		public async Task<InvoiceLineView> Add(InvoiceLineAdd add)
        {
        	try
            {
	            using (var db = new data.InvoiceContext())
	            {
	                var result= await Add(db,add);
	                await db.SaveChangesAsync();
	                return (InvoiceLineView)result;
	            }
	        }
          catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            } 
        } 	
 	
 	
 	 public async Task<data.InvoiceLine> Add(data.InvoiceContext db, InvoiceLineAdd add)
        {
         try
            {
            
            var newInvoiceLine=new data.InvoiceLine();
		    	newInvoiceLine.LineTotal = add.LineTotal;   	
		    	newInvoiceLine.Notes = add.Notes;   	
		    	newInvoiceLine.Product = add.Product;   	
		    	newInvoiceLine.ProductCode = add.ProductCode;   	
		    	newInvoiceLine.Quantity = add.Quantity;   	
		    	newInvoiceLine.SubTotal = add.SubTotal;   	
		    	newInvoiceLine.TaxExempt = add.TaxExempt;   	
		    	newInvoiceLine.TaxTotal = add.TaxTotal;   	
		    	newInvoiceLine.UnitCost = add.UnitCost;   	
    			var invoiceLookup = await db.Invoices.FirstOrDefaultAsync(w => w.InvoiceId == add.InvoiceInvoiceId);   
				if (invoiceLookup !=null)   
				{ 
					newInvoiceLine.Invoice=invoiceLookup;
				}				
    		db.InvoiceLines.Add(newInvoiceLine);    		
    		return newInvoiceLine;
            }            
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }
        }
// Update Transaction Code
 		public async Task<InvoiceLineView> Update(InvoiceLineUpdate update)
        {	
        	try
            {
	            using (var db = new data.InvoiceContext())
	            {
	                var result= await Update(db,update);
	                await db.SaveChangesAsync();
	                return (InvoiceLineView)result;
	            }
          }
          catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            } 
        } 			
 	 	
 	 public async Task<data.InvoiceLine> Update(data.InvoiceContext db, InvoiceLineUpdate update)
        {
         try
            {            
              var invoiceLineToUpdate = await db.InvoiceLines.FirstOrDefaultAsync(w => w.InvoiceLineId == update.InvoiceLineId);
            
	    	   invoiceLineToUpdate.InvoiceLineId = update.InvoiceLineId;   	
	    	   invoiceLineToUpdate.LineTotal = update.LineTotal;   	
	    	   invoiceLineToUpdate.Notes = update.Notes;   	
	    	   invoiceLineToUpdate.Product = update.Product;   	
	    	   invoiceLineToUpdate.ProductCode = update.ProductCode;   	
	    	   invoiceLineToUpdate.Quantity = update.Quantity;   	
	    	   invoiceLineToUpdate.SubTotal = update.SubTotal;   	
	    	   invoiceLineToUpdate.TaxExempt = update.TaxExempt;   	
	    	   invoiceLineToUpdate.TaxTotal = update.TaxTotal;   	
	    	   invoiceLineToUpdate.UnitCost = update.UnitCost;   	
    		return invoiceLineToUpdate;
            }            
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }
        }
    // Delete Transaction Code
    public async System.Threading.Tasks.Task Delete(InvoiceLineDelete delete)
    {
        try
        {
            using (var db = new data.InvoiceContext())
            {
	                await Delete(db,delete);
	                await db.SaveChangesAsync();	                
	            }
          }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
            } 
        } 	
 	 	
 	 public async System.Threading.Tasks.Task Delete(data.InvoiceContext db, InvoiceLineDelete delete)
   {
         try
            {            
              var invoiceLineToDelete = await db.InvoiceLines.FirstOrDefaultAsync(w => w.InvoiceLineId == delete.InvoiceLineId);
            
             	db.InvoiceLines.Remove(invoiceLineToDelete);    		
    		  }
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
            }
    }
  }
}



 
