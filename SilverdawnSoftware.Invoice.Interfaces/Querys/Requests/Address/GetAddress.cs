// ALLOWOVERWRITE-ED5967438931116F0309BA288712ABF0
using System.Collections.Generic;
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Address.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Address 
{
    public partial interface IGetAddressRequest : Orleans.IGrainWithIntegerKey
    {
        Task<IAddressView> GetAddress(IGetAddress getAddress);			
    }
}


