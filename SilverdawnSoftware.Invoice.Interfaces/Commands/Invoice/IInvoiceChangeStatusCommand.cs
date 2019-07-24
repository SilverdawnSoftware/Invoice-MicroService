// ALLOWOVERWRITE-99C8B1D4160FA956B5FD816A0CBADD3E
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice 
{
    public partial interface IInvoiceChangeStatusCommand : Orleans.IGrainWithIntegerKey
    {
        Task<IInvoiceView> InvoiceChangeStatus(IInvoiceChangeStatus invoiceChangeStatus);			
    }
}

