// ALLOWOVERWRITE-76BF5FF5AC21AB3E5858BF39D16E58AB
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity 
{
    public partial interface IEntityUpdateCommand : Orleans.IGrainWithIntegerKey
    {
        Task<IEntityView> EntityUpdate(IEntityUpdate entityUpdate);			
    }
}

