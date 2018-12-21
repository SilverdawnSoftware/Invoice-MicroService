// ALLOWOVERWRITE-CAB4345B9C03D3051132A4283D0294F7

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Silverdawn.Exceptions;
using SilverdawnSoftware.Invoice.Database.Views.Model;


namespace SilverdawnSoftware.Invoice.Database.Views
{
    public partial class CustomerViews
    {
    
    
    	public async Task<List<CustomerView>> GetAll()
        {
        	try
            {
	            using (var db = new InvoiceContext())
	            {
	                var temp = await db.Customers.ToListAsync();
	                return temp.ConvertAll(user => (CustomerView) user);
	            }
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;             
            }            
        }
    
    
    	
    	public async Task<CustomerView> Get(int customerId)
    	{
    		
    		try
            {
	    		using (var db = new InvoiceContext())
	            {
	            	if (await db.Customers.AnyAsync(w=>w.CustomerId==customerId))
	                {
	                	return (CustomerView)await db.Customers.FirstAsync(w=>w.CustomerId==customerId);
	            	}
	            }	    	
	    		return null;
    		 }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }     		
    	}
    	
    	
		
		public async Task<List<CustomerView>> GetCustomersForEntity(int entityId)
    	{
    		try
            {
    	
	    		using (var db = new InvoiceContext())
	            {
	            	var result= await db.Customers.Where(w=>w.Entity.EntityId ==entityId).ToListAsync();
	            	return result.ConvertAll(user => (CustomerView) user);
	               
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

