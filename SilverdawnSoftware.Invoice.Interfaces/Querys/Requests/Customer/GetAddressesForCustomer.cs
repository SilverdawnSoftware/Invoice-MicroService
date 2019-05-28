// ALLOWOVERWRITE-370D9E1A55FC5D8B9D99893E65F1E733
using System.Collections.Generic;
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer 
{
    public partial interface IGetAddressesForCustomerRequest : Orleans.IGrainWithIntegerKey
    {
        Task<IAddressView> GetAddressesForCustomer(IGetAddressesForCustomer getAddressesForCustomer);			
    }
}


