// ALLOWOVERWRITE-B4B763992901325E568753DCA382F6C4
using System.Collections.Generic;
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice 
{
    public partial interface IGetAllOverdueInvoicesForCustomerRequest : Orleans.IGrainWithIntegerKey
    {
        Task<IInvoiceView> GetAllOverdueInvoicesForCustomer(IGetAllOverdueInvoicesForCustomer getAllOverdueInvoicesForCustomer);			
    }
}


