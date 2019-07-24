// ALLOWOVERWRITE-4CDDC8FD5B445097A5E778391E1D4D86

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.Database.Views.Model;

namespace SilverdawnSoftware.Invoice.Database.Views
{
    public partial class PaymentHistoryViews
    {
    	public async Task<List<PaymentHistoryView>> GetAll()
        {
        	try
            {
	            using (var db = new InvoiceContext())
	            {
	                var temp = await db.PaymentHistorys.ToListAsync();
	                return temp.ConvertAll(user => (PaymentHistoryView) user);
	            }
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;             
            }            
        }
    	public async Task<PaymentHistoryView> Get(int paymentHistoryId)
    	{    		
    		try
            {
	    		using (var db = new InvoiceContext())
	            {
	            	if (await db.PaymentHistorys.AnyAsync(w=>w.PaymentHistoryId==paymentHistoryId))
	                {
	                	return (PaymentHistoryView)await db.PaymentHistorys.FirstAsync(w=>w.PaymentHistoryId==paymentHistoryId);
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
		public async Task<List<PaymentHistoryView>> GetPaymentHistorysForInvoice(int invoiceId)
    	{
    		try
            {    	
	    		using (var db = new InvoiceContext())
	            {
	            	var result= await db.PaymentHistorys.Where(w=>w.Invoice.InvoiceId ==invoiceId).ToListAsync();
	            	return result.ConvertAll(user => (PaymentHistoryView) user);	               
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


