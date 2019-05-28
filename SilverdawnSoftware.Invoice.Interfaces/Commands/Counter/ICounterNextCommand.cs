// ALLOWOVERWRITE-72098E9DFC5C16644FFBC541F663058B
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter 
{
    public partial interface ICounterNextCommand : Orleans.IGrainWithIntegerKey
    {
        Task<ICounterView> CounterNext(ICounterNext counterNext);			
    }
}

