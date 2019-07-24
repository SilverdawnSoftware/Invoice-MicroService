// ALLOWOVERWRITE-45FCE38FE129E25241627955BBC1F084
using System.Collections.Generic;
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice 
{
    public partial interface IGetAllInvoicesForCustomerRequest : Orleans.IGrainWithIntegerKey
    {
        Task<List<IInvoiceView>> GetAllInvoicesForCustomer(IGetAllInvoicesForCustomer getAllInvoicesForCustomer);
    }
}


