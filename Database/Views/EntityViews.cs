// ALLOWOVERWRITE-76B187CE7CDEC8E344BB29E2C8130E3A

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Silverdawn.Exceptions;
using SilverdawnSoftware.Invoice.Database.Views.Model;


namespace SilverdawnSoftware.Invoice.Database.Views
{
    public partial class EntityViews
    {
    
    
    	public async Task<List<EntityView>> GetAll()
        {
        	try
            {
	            using (var db = new InvoiceContext())
	            {
	                var temp = await db.Entitys.ToListAsync();
	                return temp.ConvertAll(user => (EntityView) user);
	            }
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;             
            }            
        }
    
    
    	
    	public async Task<EntityView> Get(int entityId)
    	{
    		
    		try
            {
	    		using (var db = new InvoiceContext())
	            {
	            	if (await db.Entitys.AnyAsync(w=>w.EntityId==entityId))
	                {
	                	return (EntityView)await db.Entitys.FirstAsync(w=>w.EntityId==entityId);
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

