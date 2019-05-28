// ALLOWOVERWRITE-1D02769534241C88D225F4123B42AE3F
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity 
{
    public partial interface IEntityDeleteCommand : Orleans.IGrainWithIntegerKey
    {
        Task<ICQRSBase> EntityDelete(IEntityDelete entityDelete);			
    }
}

