// ALLOWOVERWRITE-0118941D7A0F821DF9CFD94C64FB7BA0

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Silverdawn.Exceptions;
using SilverdawnSoftware.Invoice.Database.Views.Model;


namespace SilverdawnSoftware.Invoice.Database.Views
{
    public partial class AddressViews
    {
    
    
    	public async Task<List<AddressView>> GetAll()
        {
        	try
            {
	            using (var db = new InvoiceContext())
	            {
	                var temp = await db.Addresss.ToListAsync();
	                return temp.ConvertAll(user => (AddressView) user);
	            }
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;             
            }            
        }
    
    
    	
    	public async Task<AddressView> Get(int addressId)
    	{
    		
    		try
            {
	    		using (var db = new InvoiceContext())
	            {
	            	if (await db.Addresss.AnyAsync(w=>w.AddressId==addressId))
	                {
	                	return (AddressView)await db.Addresss.FirstAsync(w=>w.AddressId==addressId);
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
    	
    	
		
		public async Task<List<AddressView>> GetAddresssForCustomer(int customerId)
    	{
    		try
            {
    	
	    		using (var db = new InvoiceContext())
	            {
	            	var result= await db.Addresss.Where(w=>w.Customer.CustomerId ==customerId).ToListAsync();
	            	return result.ConvertAll(user => (AddressView) user);
	               
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

