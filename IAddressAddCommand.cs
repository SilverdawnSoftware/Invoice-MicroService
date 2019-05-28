// ALLOWOVERWRITE-9F510FF519341CC962EBE0363CF01B74
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Address.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Address 
{
    public partial interface IAddressAddCommand : Orleans.IGrainWithIntegerKey
    {
        Task<IAddressView> AddressAdd(IAddressAdd addressAdd);
    }
}

