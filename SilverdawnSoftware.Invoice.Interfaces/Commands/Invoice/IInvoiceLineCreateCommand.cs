// ALLOWOVERWRITE-2A71E22D2CF69719A8F4CFBAC25C1364
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.InvoiceLine.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.InvoiceLine 
{
    public partial interface IInvoiceLineCreateCommand : Orleans.IGrainWithIntegerKey
    {
        Task<IInvoiceLineView> InvoiceLineCreate(IInvoiceLineCreate invoiceLineCreate);
    }
}

