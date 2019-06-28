// ALLOWOVERWRITE-A80C80A70FE07F61C9DDABEAAA6BC8A5-2C49A55328EF062E9B17572451621CE8
using System.Collections.Generic;
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Counter.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Counter 
{
    public partial interface IGetCounterRequest : Orleans.IGrainWithIntegerKey
    {
        Task<ICounterView> GetCounter(IGetCounter getCounter);			
    }
}


