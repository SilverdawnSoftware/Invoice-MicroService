// ALLOWOVERWRITE-61F262A12BE924709AEFB3C42F95AD87-2EFA1174B0552DA189639A602DFF8C76

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
 public partial class CounterTransactions
 {
      
 		// Add Transaction Code
 		public async Task<CounterView> Add(CounterAdd add)
        {
        	try
            {
	            using (var db = new data.InvoiceContext())
	            {
	                var result= await Add(db,add);
	                await db.SaveChangesAsync();
	                return (CounterView)result;
	            }
	        }
          catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            } 
        } 	
 	
 	
 	 public async Task<data.Counter> Add(data.InvoiceContext db, CounterAdd add)
        {
         try
            {
            
            var newCounter=new data.Counter();
		    	newCounter.Value = add.Value;   	
    		db.Counters.Add(newCounter);    		
    		return newCounter;
            }            
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }
        }
// Update Transaction Code
 		public async Task<CounterView> Update(CounterUpdate update)
        {	
        	try
            {
	            using (var db = new data.InvoiceContext())
	            {
	                var result= await Update(db,update);
	                await db.SaveChangesAsync();
	                return (CounterView)result;
	            }
          }
          catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            } 
        } 			
 	 	
 	 public async Task<data.Counter> Update(data.InvoiceContext db, CounterUpdate update)
        {
         try
            {            
              var counterToUpdate = await db.Counters.FirstOrDefaultAsync(w => w.Name == update.Name);
            
	    	   counterToUpdate.Name = update.Name;   	
	    	   counterToUpdate.Value = update.Value;   	
    		return counterToUpdate;
            }            
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }
        }
    // Delete Transaction Code
    public async System.Threading.Tasks.Task Delete(CounterDelete delete)
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
 	 	
 	 public async System.Threading.Tasks.Task Delete(data.InvoiceContext db, CounterDelete delete)
   {
         try
            {            
              var counterToDelete = await db.Counters.FirstOrDefaultAsync(w => w.Name == delete.Name);
            
             	db.Counters.Remove(counterToDelete);    		
    		  }
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
            }
    }

 	}
}
 
