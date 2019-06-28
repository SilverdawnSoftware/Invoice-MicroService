// ALLOWOVERWRITE-6508089E5E076D635FFFF2166E90476A-0B1CB29447D72B395D80CAAE8D809630
using System.Collections.Generic;
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer 
{
    public partial interface IGetCustomerRequest : Orleans.IGrainWithIntegerKey
    {
        Task<ICustomerView> GetCustomer(IGetCustomer getCustomer);			
    }
}


