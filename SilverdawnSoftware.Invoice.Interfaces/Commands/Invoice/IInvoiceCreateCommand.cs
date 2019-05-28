// ALLOWOVERWRITE-BD7697F8289BB6E6B371692F2E64398C
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice 
{
    public partial interface IInvoiceCreateCommand : Orleans.IGrainWithIntegerKey
    {
        Task<IInvoiceView> InvoiceCreate(IInvoiceCreate invoiceCreate);
    }
}

