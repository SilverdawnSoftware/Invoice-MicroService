// ALLOWOVERWRITE-9D540C98BA77297FDC52EE6050289D6F-885EF6626E0F89646D3121EE6421B077
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice 
{
    public partial interface IInvoiceUpdateCommand : Orleans.IGrainWithIntegerKey
    {
        Task<IInvoiceView> InvoiceUpdate(IInvoiceUpdate invoiceUpdate);			
    }
}

