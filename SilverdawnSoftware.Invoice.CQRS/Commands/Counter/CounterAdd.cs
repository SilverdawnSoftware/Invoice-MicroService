// ALLOWOVERWRITE-0209806F89CC255B35E9F4739E375B74
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
  	public partial class CounterAddCommand : Orleans.Grain , ICounterAddCommand
    {

		
      public async Task<ICounterView> CounterAdd(ICounterAdd counterAdd)
      {
			try
          {
              var result=new CounterView();
              using (var db=new InvoiceContext())
              {
                   var counter = new Database.Counter();
                   db.Counters.Add(counter);
                   counter.Name=counterAdd.Name;  	
                   counter.Value=counterAdd.Value;  	
                   //UserCodeBlockStart-PreSave
                   //UserCodeBlockEnd-PreSave
                   await db.SaveChangesAsync();

                   result.Name=counter.Name;
                   result.Value=counter.Value;
                   //UserCodeBlockStart-PreResult
                   //UserCodeBlockEnd-PreResult
                   return result;
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

