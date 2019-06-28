
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.Database.Views.Model;

namespace SilverdawnSoftware.Invoice.Database.Views
{
    public partial class CounterViews
    {
    	public async Task<List<CounterView>> GetAll()
        {
        	try
            {
	            using (var db = new InvoiceContext())
	            {
	                var temp = await db.Counters.ToListAsync();
	                return temp.ConvertAll(user => (CounterView) user);
	            }
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;             
            }            
        }
    	public async Task<CounterView> Get(string name)
    	{    		
    		try
            {
	    		using (var db = new InvoiceContext())
	            {
	            	if (await db.Counters.AnyAsync(w=>w.Name==name))
	                {
	                	return (CounterView)await db.Counters.FirstAsync(w=>w.Name==name);
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
    }
}


