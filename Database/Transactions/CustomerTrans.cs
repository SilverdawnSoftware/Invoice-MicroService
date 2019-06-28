// ALLOWOVERWRITE-BA439947C0B9AF0EDE13290A91998FFD-C124AF090DDDB37F9D0DDDBCDE4E40A8

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
 public partial class CustomerTransactions
 {
      
 		// Add Transaction Code
 		public async Task<CustomerView> Add(CustomerAdd add)
        {
        	try
            {
	            using (var db = new data.InvoiceContext())
	            {
	                var result= await Add(db,add);
	                await db.SaveChangesAsync();
	                return (CustomerView)result;
	            }
	        }
          catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            } 
        } 	
 	
 	
 	 public async Task<data.Customer> Add(data.InvoiceContext db, CustomerAdd add)
        {
         try
            {
            
            var newCustomer=new data.Customer();
		    	newCustomer.Active = add.Active;   	
			newCustomer.Address  = add.Address;				  			
		    	newCustomer.CustomerExteranlRef = add.CustomerExteranlRef;   	
		    	newCustomer.EmailAddress = add.EmailAddress;   	
		    	newCustomer.IsCompany = add.IsCompany;   	
		    	newCustomer.Name = add.Name;   	
		    	newCustomer.PhoneNumber = add.PhoneNumber;   	
		    	newCustomer.TaxNo = add.TaxNo;   	
    			var entityLookup = await db.Entitys.FirstOrDefaultAsync(w => w.EntityId == add.EntityEntityId);   
				if (entityLookup !=null)   
				{ 
					newCustomer.Entity=entityLookup;
				}				
    		db.Customers.Add(newCustomer);    		
    		return newCustomer;
            }            
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }
        }
// Update Transaction Code
 		public async Task<CustomerView> Update(CustomerUpdate update)
        {	
        	try
            {
	            using (var db = new data.InvoiceContext())
	            {
	                var result= await Update(db,update);
	                await db.SaveChangesAsync();
	                return (CustomerView)result;
	            }
          }
          catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            } 
        } 			
 	 	
 	 public async Task<data.Customer> Update(data.InvoiceContext db, CustomerUpdate update)
        {
         try
            {            
              var customerToUpdate = await db.Customers.FirstOrDefaultAsync(w => w.CustomerId == update.CustomerId);
            
	    	   customerToUpdate.Active = update.Active;   	
				customerToUpdate.Address = update.Address;
	    	   customerToUpdate.CustomerExteranlRef = update.CustomerExteranlRef;   	
	    	   customerToUpdate.CustomerId = update.CustomerId;   	
	    	   customerToUpdate.EmailAddress = update.EmailAddress;   	
	    	   customerToUpdate.IsCompany = update.IsCompany;   	
	    	   customerToUpdate.Name = update.Name;   	
	    	   customerToUpdate.PhoneNumber = update.PhoneNumber;   	
	    	   customerToUpdate.TaxNo = update.TaxNo;   	
    		return customerToUpdate;
            }            
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }
        }
    // Delete Transaction Code
    public async System.Threading.Tasks.Task Delete(CustomerDelete delete)
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
 	 	
 	 public async System.Threading.Tasks.Task Delete(data.InvoiceContext db, CustomerDelete delete)
   {
         try
            {            
              var customerToDelete = await db.Customers.FirstOrDefaultAsync(w => w.CustomerId == delete.CustomerId);
            
             	db.Customers.Remove(customerToDelete);    		
    		  }
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
            }
    }
  }
}



 
