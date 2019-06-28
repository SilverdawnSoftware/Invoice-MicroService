// ALLOWOVERWRITE-272CF10007AA8E8B6380B556ECFE2AC8-C669CC23A1B850C1AA0A27D197426CF3
using System.Collections.Generic;
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice 
{
    public partial interface IGetAllInvoiceLinesForInvoiceRequest : Orleans.IGrainWithIntegerKey
    {
        Task<List<IInvoiceLineView>> GetAllInvoiceLinesForInvoice(IGetAllInvoiceLinesForInvoice getAllInvoiceLinesForInvoice);
    }
}


