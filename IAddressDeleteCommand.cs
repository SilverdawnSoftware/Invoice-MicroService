// ALLOWOVERWRITE-A88F68857440BADA3758D983BD156C78
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Address.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Address 
{
    public partial interface IAddressDeleteCommand : Orleans.IGrainWithIntegerKey
    {
        Task<ICQRSBase> AddressDelete(IAddressDelete addressDelete);			
    }
}

