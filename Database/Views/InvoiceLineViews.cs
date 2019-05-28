// ALLOWOVERWRITE-121EB411C14DF056BCD41E32C514B589

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.Database.Views.Model;


namespace SilverdawnSoftware.Invoice.Database.Views
{
    public partial class InvoiceLineViews
    {
    
    
    	public async Task<List<InvoiceLineView>> GetAll()
        {
        	try
            {
	            using (var db = new InvoiceContext())
	            {
	                var temp = await db.InvoiceLines.ToListAsync();
	                return temp.ConvertAll(user => (InvoiceLineView) user);
	            }
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;             
            }            
        }
    
    
    	
    	public async Task<InvoiceLineView> Get(int invoiceLineId)
    	{
    		
    		try
            {
	    		using (var db = new InvoiceContext())
	            {
	            	if (await db.InvoiceLines.AnyAsync(w=>w.InvoiceLineId==invoiceLineId))
	                {
	                	return (InvoiceLineView)await db.InvoiceLines.FirstAsync(w=>w.InvoiceLineId==invoiceLineId);
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
    	
    	
		
		public async Task<List<InvoiceLineView>> GetInvoiceLinesForInvoice(int invoiceId)
    	{
    		try
            {
    	
	    		using (var db = new InvoiceContext())
	            {
	            	var result= await db.InvoiceLines.Where(w=>w.Invoice.InvoiceId ==invoiceId).ToListAsync();
	            	return result.ConvertAll(user => (InvoiceLineView) user);
	               
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

