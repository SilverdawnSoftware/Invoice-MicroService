// ALLOWOVERWRITE-9501009D6F8A0326896FB29AAA02543C

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
 public partial class PaymentHistoryTransactions
 {
      
 		// Add Transaction Code
 		public async Task<PaymentHistoryView> Add(PaymentHistoryAdd add)
        {
        	try
            {
	            using (var db = new data.InvoiceContext())
	            {
	                var result= await Add(db,add);
	                await db.SaveChangesAsync();
	                return (PaymentHistoryView)result;
	            }
	        }
          catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            } 
        } 	
 	
 	
 	 public async Task<data.PaymentHistory> Add(data.InvoiceContext db, PaymentHistoryAdd add)
        {
         try
            {
            
            var newPaymentHistory=new data.PaymentHistory();
		    	newPaymentHistory.Amount = add.Amount;   	
		    	newPaymentHistory.PaymentDate = add.PaymentDate;   	
		    	newPaymentHistory.Reference = add.Reference;   	
    			var invoiceLookup = await db.Invoices.FirstOrDefaultAsync(w => w.InvoiceId == add.InvoiceInvoiceId);   
				if (invoiceLookup !=null)   
				{ 
					newPaymentHistory.Invoice=invoiceLookup;
				}				
    		db.PaymentHistorys.Add(newPaymentHistory);    		
    		return newPaymentHistory;
            }            
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }
        }
// Update Transaction Code
 		public async Task<PaymentHistoryView> Update(PaymentHistoryUpdate update)
        {	
        	try
            {
	            using (var db = new data.InvoiceContext())
	            {
	                var result= await Update(db,update);
	                await db.SaveChangesAsync();
	                return (PaymentHistoryView)result;
	            }
          }
          catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            } 
        } 			
 	 	
 	 public async Task<data.PaymentHistory> Update(data.InvoiceContext db, PaymentHistoryUpdate update)
        {
         try
            {            
              var paymentHistoryToUpdate = await db.PaymentHistorys.FirstOrDefaultAsync(w => w.PaymentHistoryId == update.PaymentHistoryId);
            
	    	   paymentHistoryToUpdate.Amount = update.Amount;   	
	    	   paymentHistoryToUpdate.PaymentDate = update.PaymentDate;   	
	    	   paymentHistoryToUpdate.PaymentHistoryId = update.PaymentHistoryId;   	
	    	   paymentHistoryToUpdate.Reference = update.Reference;   	
    		return paymentHistoryToUpdate;
            }            
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }
        }
    // Delete Transaction Code
    public async System.Threading.Tasks.Task Delete(PaymentHistoryDelete delete)
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
 	 	
 	 public async System.Threading.Tasks.Task Delete(data.InvoiceContext db, PaymentHistoryDelete delete)
   {
         try
            {            
              var paymentHistoryToDelete = await db.PaymentHistorys.FirstOrDefaultAsync(w => w.PaymentHistoryId == delete.PaymentHistoryId);
            
             	db.PaymentHistorys.Remove(paymentHistoryToDelete);    		
    		  }
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
            }
    }
  }
}



 
