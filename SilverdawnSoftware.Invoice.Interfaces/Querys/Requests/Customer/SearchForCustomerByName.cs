// ALLOWOVERWRITE-CB9D7ED435073DAF7FAE7928A4B84521-40B83E42B5BF5725380418A4DFB8DFFE
using System.Collections.Generic;
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer 
{
    public partial interface ISearchForCustomerByNameRequest : Orleans.IGrainWithIntegerKey
    {
        Task<ICustomerView> SearchForCustomerByName(ISearchForCustomerByName searchForCustomerByName);			
    }
}


