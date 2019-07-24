// ALLOWOVERWRITE-4881C354609247DD286350E7FAB1AA6C
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.InvoiceLine.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.InvoiceLine 
{
    public partial interface IInvoiceLineAddCommand : Orleans.IGrainWithIntegerKey
    {
        Task<IInvoiceLineView> InvoiceLineAdd(IInvoiceLineAdd invoiceLineAdd);
    }
}

