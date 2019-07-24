// ALLOWOVERWRITE-0F726BBDC0974B0C8D085C3C9C0E81F3

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Counter.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Counter;
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Database;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Counter
{
    public partial class GetCounterRequest : Orleans.Grain , IGetCounterRequest
    {
   		public async  Task<ICounterView>  GetCounter(IGetCounter getCounter)
   		{
   			try
	            {
	            var result=new CounterView();
	            using (var db=new InvoiceContext())
	            {
	                if (await db.Counters.AnyAsync(w =>  w.Name == getCounter.Name))
	                {
	                   var counter = await db.Counters.FirstAsync(w =>  w.Name == getCounter.Name);
                       result.Name=counter.Name;
                       result.Value=counter.Value;
				       return result;
	                }
                    else
                    {
                    return new CounterView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to find item",__CQRSStatusCode = 500};                                  
                    }
	            }
	            }
	            catch (Exception e)
	            {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    return new CounterView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create CounterView",__CQRSStatusCode = 500};             
	            }
   			}
   		
    }    
}




