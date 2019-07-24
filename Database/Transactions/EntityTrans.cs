// ALLOWOVERWRITE-A2F77409928B3B2C811CA6374848521F

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
 public partial class EntityTransactions
 {
      
 		// Add Transaction Code
 		public async Task<EntityView> Add(EntityAdd add)
        {
        	try
            {
	            using (var db = new data.InvoiceContext())
	            {
	                var result= await Add(db,add);
	                await db.SaveChangesAsync();
	                return (EntityView)result;
	            }
	        }
          catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            } 
        } 	
 	
 	
 	 public async Task<data.Entity> Add(data.InvoiceContext db, EntityAdd add)
        {
         try
            {
            
            var newEntity=new data.Entity();
			newEntity.Address  = add.Address;				  			
		    	newEntity.EntityExternalRef = add.EntityExternalRef;   	
		    	newEntity.LogoURL = add.LogoURL;   	
		    	newEntity.Name = add.Name;   	
		    	newEntity.SMTPEmailDisplayName = add.SMTPEmailDisplayName;   	
		    	newEntity.SMTPEmailFromAddress = add.SMTPEmailFromAddress;   	
		    	newEntity.SMTPHost = add.SMTPHost;   	
		    	newEntity.SMTPPassword = add.SMTPPassword;   	
		    	newEntity.SMTPUserName = add.SMTPUserName;   	
    		db.Entitys.Add(newEntity);    		
    		return newEntity;
            }            
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }
        }
// Update Transaction Code
 		public async Task<EntityView> Update(EntityUpdate update)
        {	
        	try
            {
	            using (var db = new data.InvoiceContext())
	            {
	                var result= await Update(db,update);
	                await db.SaveChangesAsync();
	                return (EntityView)result;
	            }
          }
          catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            } 
        } 			
 	 	
 	 public async Task<data.Entity> Update(data.InvoiceContext db, EntityUpdate update)
        {
         try
            {            
              var entityToUpdate = await db.Entitys.FirstOrDefaultAsync(w => w.EntityId == update.EntityId);
            
				entityToUpdate.Address = update.Address;
	    	   entityToUpdate.EntityExternalRef = update.EntityExternalRef;   	
	    	   entityToUpdate.EntityId = update.EntityId;   	
	    	   entityToUpdate.LogoURL = update.LogoURL;   	
	    	   entityToUpdate.Name = update.Name;   	
	    	   entityToUpdate.SMTPEmailDisplayName = update.SMTPEmailDisplayName;   	
	    	   entityToUpdate.SMTPEmailFromAddress = update.SMTPEmailFromAddress;   	
	    	   entityToUpdate.SMTPHost = update.SMTPHost;   	
	    	   entityToUpdate.SMTPPassword = update.SMTPPassword;   	
	    	   entityToUpdate.SMTPUserName = update.SMTPUserName;   	
    		return entityToUpdate;
            }            
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }
        }
    // Delete Transaction Code
    public async System.Threading.Tasks.Task Delete(EntityDelete delete)
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
 	 	
 	 public async System.Threading.Tasks.Task Delete(data.InvoiceContext db, EntityDelete delete)
   {
         try
            {            
              var entityToDelete = await db.Entitys.FirstOrDefaultAsync(w => w.EntityId == delete.EntityId);
            
             	db.Entitys.Remove(entityToDelete);    		
    		  }
             catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
            }
    }
  }
}



 
