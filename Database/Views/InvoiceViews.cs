// ALLOWOVERWRITE-B0090E2A32E23DA84D27701E97A1BAA3

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.Database.Views.Model;


namespace SilverdawnSoftware.Invoice.Database.Views
{
    public partial class InvoiceViews
    {
    
    
    	public async Task<List<InvoiceView>> GetAll()
        {
        	try
            {
	            using (var db = new InvoiceContext())
	            {
	                var temp = await db.Invoices.ToListAsync();
	                return temp.ConvertAll(user => (InvoiceView) user);
	            }
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;             
            }            
        }
    
    
    	
    	public async Task<InvoiceView> Get(int invoiceId)
    	{
    		
    		try
            {
	    		using (var db = new InvoiceContext())
	            {
	            	if (await db.Invoices.AnyAsync(w=>w.InvoiceId==invoiceId))
	                {
	                	return (InvoiceView)await db.Invoices.FirstAsync(w=>w.InvoiceId==invoiceId);
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
    	
    	
		
		public async Task<List<InvoiceView>> GetInvoicesForCustomer(int customerId)
    	{
    		try
            {
    	
	    		using (var db = new InvoiceContext())
	            {
	            	var result= await db.Invoices.Where(w=>w.Customer.CustomerId ==customerId).ToListAsync();
	            	return result.ConvertAll(user => (InvoiceView) user);
	               
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

