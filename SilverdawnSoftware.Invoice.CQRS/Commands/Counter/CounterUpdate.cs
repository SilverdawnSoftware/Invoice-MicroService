// ALLOWOVERWRITE-48649879D47E45751055E6C1D7A399DF
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter.Models;
using SilverdawnSoftware.Invoice.Interfaces;
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Database;


namespace SilverdawnSoftware.Invoice.CQRS.Commands.Counter
{
  	public partial class CounterUpdateCommand : Orleans.Grain , ICounterUpdateCommand
    {


        /// <summary>  </summary>
        /// <param name="invoiceAdd">this is a test</param>
        /// <returns></returns>
        /// <remarks>
        /// ///

        /// </remarks>
      public async Task<ICounterView> CounterUpdate(ICounterUpdate counterUpdate)
      {
			try
          {
              var result=new CounterView();
              using (var db=new InvoiceContext())
              {
                   if (db.Counters.Any(w =>  w.Name == counterUpdate.Name))
                   {
                       var counter = db.Counters.First(w =>  w.Name == counterUpdate.Name);
                    counter.Value=counterUpdate.Value;  	
                       await db.SaveChangesAsync();

                       result.Name=counter.Name;
                       result.Value=counter.Value;
                       return result;
                   }
               }
           }
              catch (Exception e)
                {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    return new CounterView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create CounterView",__CQRSStatusCode = 500};     
                } 
               return null;         
               }
	}



}
