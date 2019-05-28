// ALLOWOVERWRITE-A6812FE13C415929C89CD1285039A9EF
using System.Collections.Generic;
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer 
{
    public partial interface IGetOutStandingInvoicesForCustomerRequest : Orleans.IGrainWithIntegerKey
    {
        Task<List<IInvoiceView>> GetOutStandingInvoicesForCustomer(IGetOutStandingInvoicesForCustomer getOutStandingInvoicesForCustomer);
    }
}


