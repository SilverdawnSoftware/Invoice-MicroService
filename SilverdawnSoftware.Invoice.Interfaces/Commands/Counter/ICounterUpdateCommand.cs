// ALLOWOVERWRITE-54268D2003B2D376BF028D727BF4F991
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter 
{
    public partial interface ICounterUpdateCommand : Orleans.IGrainWithIntegerKey
    {
        Task<ICounterView> CounterUpdate(ICounterUpdate counterUpdate);			
    }
}

