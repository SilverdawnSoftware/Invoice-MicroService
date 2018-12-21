// ALLOWOVERWRITE-E1450C863F0CA5994DCAED01A58FF89A

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Silverdawn.Exceptions;
using SilverdawnSoftware.Invoice.Database.Transactions.Model;
using SilverdawnSoftware.Invoice.Database.Views.Model;
using data = SilverdawnSoftware.Invoice.Database;

namespace SilverdawnSoftware.Invoice.Database.Transactions
{
 public partial class AddressTransactions
 {
     
 
 		// Add Transaction Code
 		public async Task<AddressView> Add(AddressAdd add)
        {
        	try
            {
	            using (var db = new data.InvoiceContext())
	            {
	                var result= await Add(db,add);
	                await db.SaveChangesAsync();
	                return (AddressView)result;
	            }
	        }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;
              
            } 
        } 	
 	
 	
 	 public async Task<data.Address> Add(data.InvoiceContext db, AddressAdd add)
        {
         try
            {
            
            var newAddress=new data.Address();
	    	newAddress.AddresLine2 = add.AddresLine2;   	
	    	newAddress.AddressExternalRef = add.AddressExternalRef;   	
	    	newAddress.AddressLine1 = add.AddressLine1;   	
	    	newAddress.AddressLine3 = add.AddressLine3;   	
	    	newAddress.City = add.City;   	
	    	newAddress.Country = add.Country;   	
	    	newAddress.PostZipCode = add.PostZipCode;   	
	    	newAddress.StateCounty = add.StateCounty;   	
    	
    		// Add references to parent Classes
    			var customerLookup = await db.Customers.FirstOrDefaultAsync(w => w.CustomerId == add.CustomerCustomerId);   
				if (customerLookup !=null)    
				{ newAddress.Customer=customerLookup;}	
    	
    	
    		db.Addresss.Add(newAddress);
    		
    		return newAddress;
            }
            
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;
              
            }
        }



// Update Transaction Code
 		public async Task<AddressView> Update(AddressUpdate update)
        {	
        	try
            {
	            using (var db = new data.InvoiceContext())
	            {
	                var result= await Update(db,update);
	                await db.SaveChangesAsync();
	                return (AddressView)result;
	            }
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;
              
            } 
        } 			
 	
 	
 	 public async Task<data.Address> Update(data.InvoiceContext db, AddressUpdate update)
        {
         try
            {
              var addressToUpdate = await db.Addresss.FirstOrDefaultAsync(w => w.AddressId == update.AddressId);

               
            	
addressToUpdate.AddresLine2 = update.AddresLine2;   	
addressToUpdate.AddressExternalRef = update.AddressExternalRef;   	
addressToUpdate.AddressId = update.AddressId;   	
addressToUpdate.AddressLine1 = update.AddressLine1;   	
addressToUpdate.AddressLine3 = update.AddressLine3;   	
addressToUpdate.City = update.City;   	
addressToUpdate.Country = update.Country;   	
addressToUpdate.PostZipCode = update.PostZipCode;   	
addressToUpdate.StateCounty = update.StateCounty;   	
            	
    	
    		
    		
    		return addressToUpdate;
            }
            
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;
              
            }
        }


	// Delete Transaction Code
 		public async System.Threading.Tasks.Task Delete(AddressDelete delete)
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
 	
 	
 	 public async System.Threading.Tasks.Task Delete(data.InvoiceContext db, AddressDelete delete)
        {
         try
            {
            
              var addressToDelete = await db.Addresss.FirstOrDefaultAsync(w => w.AddressId == delete.AddressId);
            
             	db.Addresss.Remove(addressToDelete);    		
    		}
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
            }
        }
        

	}
 }
 
