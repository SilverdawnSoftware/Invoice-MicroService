// ALLOWOVERWRITE-6A55F59B612485BF60AB37CEF2EAADB7

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
 public partial class InvoiceTransactions
 {
      
 		// Add Transaction Code
 		public async Task<InvoiceView> Add(InvoiceAdd add)
        {
        	try
            {
	            using (var db = new data.InvoiceContext())
	            {
	                var result= await Add(db,add);
	                await db.SaveChangesAsync();
	                return (InvoiceView)result;
	            }
	        }
          catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            } 
        } 	
 	
 	
 	 public async Task<data.Invoice> Add(data.InvoiceContext db, InvoiceAdd add)
        {
         try
            {
            
            var newInvoice=new data.Invoice();
			newInvoice.BillingAddress  = add.BillingAddress;				  			
		    	newInvoice.CreatedDate = add.CreatedDate;   	
		    	newInvoice.DueDate = add.DueDate;   	
		    	newInvoice.EmailTo = add.EmailTo;   	
		    	newInvoice.GrandTotal = add.GrandTotal;   	
		    	newInvoice.InvoiceEmailed = add.InvoiceEmailed;   	
		    	newInvoice.InvoiceNo = add.InvoiceNo;   	
		    	newInvoice.Notes = add.Notes;   	
		    	newInvoice.OrderedBy = add.OrderedBy;   	
		    	newInvoice.PaidAmount = add.PaidAmount;   	
		    	newInvoice.PaidDate = add.PaidDate;   	
		    	newInvoice.PaidTax = add.PaidTax;   	
		    	newInvoice.PaymentDetails = add.PaymentDetails;   	
		    	newInvoice.PurchaseOrderRef = add.PurchaseOrderRef;   	
			newInvoice.ShippingAddress  = add.ShippingAddress;				  			
		    	newInvoice.SubTotal = add.SubTotal;   	
		    	newInvoice.TaxTotal = add.TaxTotal;   	
		    	newInvoice.TermsAndConditions  = add.TermsAndConditions ;   	
    			var customerLookup = await db.Customers.FirstOrDefaultAsync(w => w.CustomerId == add.CustomerCustomerId);   
				if (customerLookup !=null)   
				{ 
					newInvoice.Customer=customerLookup;
				}				
    		db.Invoices.Add(newInvoice);    		
    		return newInvoice;
            }            
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }
        }
// Update Transaction Code
 		public async Task<InvoiceView> Update(InvoiceUpdate update)
        {	
        	try
            {
	            using (var db = new data.InvoiceContext())
	            {
	                var result= await Update(db,update);
	                await db.SaveChangesAsync();
	                return (InvoiceView)result;
	            }
          }
          catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            } 
        } 			
 	 	
 	 public async Task<data.Invoice> Update(data.InvoiceContext db, InvoiceUpdate update)
        {
         try
            {            
              var invoiceToUpdate = await db.Invoices.FirstOrDefaultAsync(w => w.InvoiceId == update.InvoiceId);
            
				invoiceToUpdate.BillingAddress = update.BillingAddress;
	    	   invoiceToUpdate.CreatedDate = update.CreatedDate;   	
	    	   invoiceToUpdate.DueDate = update.DueDate;   	
	    	   invoiceToUpdate.EmailTo = update.EmailTo;   	
	    	   invoiceToUpdate.GrandTotal = update.GrandTotal;   	
	    	   invoiceToUpdate.InvoiceEmailed = update.InvoiceEmailed;   	
	    	   invoiceToUpdate.InvoiceId = update.InvoiceId;   	
	    	   invoiceToUpdate.InvoiceNo = update.InvoiceNo;   	
	    	   invoiceToUpdate.Notes = update.Notes;   	
	    	   invoiceToUpdate.OrderedBy = update.OrderedBy;   	
	    	   invoiceToUpdate.PaidAmount = update.PaidAmount;   	
	    	   invoiceToUpdate.PaidDate = update.PaidDate;   	
	    	   invoiceToUpdate.PaidTax = update.PaidTax;   	
	    	   invoiceToUpdate.PaymentDetails = update.PaymentDetails;   	
	    	   invoiceToUpdate.PurchaseOrderRef = update.PurchaseOrderRef;   	
				invoiceToUpdate.ShippingAddress = update.ShippingAddress;
	    	   invoiceToUpdate.SubTotal = update.SubTotal;   	
	    	   invoiceToUpdate.TaxTotal = update.TaxTotal;   	
	    	   invoiceToUpdate.TermsAndConditions  = update.TermsAndConditions ;   	
    		return invoiceToUpdate;
            }            
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }
        }
    // Delete Transaction Code
    public async System.Threading.Tasks.Task Delete(InvoiceDelete delete)
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
 	 	
 	 public async System.Threading.Tasks.Task Delete(data.InvoiceContext db, InvoiceDelete delete)
   {
         try
            {            
              var invoiceToDelete = await db.Invoices.FirstOrDefaultAsync(w => w.InvoiceId == delete.InvoiceId);
            
             	db.Invoices.Remove(invoiceToDelete);    		
    		  }
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
            }
    }
  }
}



 
