// ALLOWOVERWRITE-C50E9AA92CEAFD13E17C4A0BC64023A9
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
    public partial class CounterNextCommand : Orleans.Grain, ICounterNextCommand
    {


        public async Task<ICounterView> CounterNext(ICounterNext counterNext)
        {
            try
            {
                var result = new CounterView();
                using (var db = new InvoiceContext())
                {
                    if (db.Counters.Any(w => w.Name == counterNext.Name))
                    {
                        var counter = db.Counters.First(w => w.Name == counterNext.Name);
                        counter.Name = counterNext.Name;
                        //UserCodeBlockStart-1
                        counter.Value = counter.Value + 1;
                        //UserCodeBlockEnd-1
                        await db.SaveChangesAsync();

                        result.Name = counter.Name;
                        result.Value = counter.Value;
                        return result;
                    }
                    else
                    {
                        var newCounter = new Database.Counter();
                        db.Counters.Add(newCounter);
                        newCounter.Name = counterNext.Name;
                        newCounter.Value = 1;
                        await db.SaveChangesAsync();

                        result.Name = newCounter.Name;
                        result.Value = newCounter.Value;
                        return result;
                    }
                }
            }
            catch (Exception e)
            {
                LogFactory.GetLogger().Log(LogLevel.Error, e);
                return new CounterView() {__CQRSSuccessful = false, __CQRSErrorMessage = "Unable to create CounterView", __CQRSStatusCode = 500};
            }

            return null;
        }
    }

}
