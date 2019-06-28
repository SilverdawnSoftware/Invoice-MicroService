// ALLOWOVERWRITE-30CEDB2832D3B07D8F4C9B0F7439C2BC-EE54089CCA6A86AC4A2634F39F16E876
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice 
{
    public partial interface IInvoicePayCommand : Orleans.IGrainWithIntegerKey
    {
        Task<IInvoiceView> InvoicePay(IInvoicePay invoicePay);			
    }
}

