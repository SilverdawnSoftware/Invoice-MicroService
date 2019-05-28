// ALLOWOVERWRITE-2FCAA5CF054E6AFBDBDAAABA194CAA8E
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Address.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Address 
{
    public partial interface IAddressUpdateCommand : Orleans.IGrainWithIntegerKey
    {
        Task<IAddressView> AddressUpdate(IAddressUpdate addressUpdate);			
    }
}

