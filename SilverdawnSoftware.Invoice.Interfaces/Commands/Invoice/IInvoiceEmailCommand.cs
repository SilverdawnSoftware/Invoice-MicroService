// ALLOWOVERWRITE-79EE175434909CEB11EDF7F40C5EA4E6-E833D4290CBFA0336A27CB88B258B4BC
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice 
{
    public partial interface IInvoiceEmailCommand : Orleans.IGrainWithIntegerKey
    {
        Task<IInvoiceView> InvoiceEmail(IInvoiceEmail invoiceEmail);			
    }
}

