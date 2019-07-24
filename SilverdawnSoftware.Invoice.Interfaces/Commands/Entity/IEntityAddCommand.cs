// ALLOWOVERWRITE-6B18992F1187A020C6C1A6DEC59911C8
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity 
{
    public partial interface IEntityAddCommand : Orleans.IGrainWithIntegerKey
    {
        Task<IEntityView> EntityAdd(IEntityAdd entityAdd);
    }
}

