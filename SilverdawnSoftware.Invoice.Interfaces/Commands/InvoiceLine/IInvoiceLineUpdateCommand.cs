// ALLOWOVERWRITE-E80F6DFCB2A2446EF3BCBC275ABA7DDB-7E62A7FE12AB47AF96CA255CFF6CDDAA
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.InvoiceLine.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.InvoiceLine 
{
    public partial interface IInvoiceLineUpdateCommand : Orleans.IGrainWithIntegerKey
    {
        Task<IInvoiceLineView> InvoiceLineUpdate(IInvoiceLineUpdate invoiceLineUpdate);			
    }
}

