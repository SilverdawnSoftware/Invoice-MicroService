// ALLOWOVERWRITE-89DD6C47CF6835A71FFEAD8C453E9284
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice 
{
    public partial interface IInvoiceUpdateNotesCommand : Orleans.IGrainWithIntegerKey
    {
        Task<IInvoiceView> InvoiceUpdateNotes(IInvoiceUpdateNotes invoiceUpdateNotes);			
    }
}

