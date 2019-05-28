// ALLOWOVERWRITE-AE75971EDD1BF9918BBFA548237C8D28
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice 
{
    public partial interface IInvoiceCancelCommand : Orleans.IGrainWithIntegerKey
    {
        Task<IInvoiceView> InvoiceCancel(IInvoiceCancel invoiceCancel);			
    }
}

