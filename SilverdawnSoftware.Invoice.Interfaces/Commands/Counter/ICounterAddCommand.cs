// ALLOWOVERWRITE-5A91D501D616959545BA6B0437C9DA78-309B411B885979A41BA01A78280D241E
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter 
{
    public partial interface ICounterAddCommand : Orleans.IGrainWithIntegerKey
    {
        Task<ICounterView> CounterAdd(ICounterAdd counterAdd);
    }
}

