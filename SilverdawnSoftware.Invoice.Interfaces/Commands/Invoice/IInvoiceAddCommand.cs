// ALLOWOVERWRITE-60E92DDB52FBB4CB0BE807634CAFF43E
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice 
{
    public partial interface IInvoiceAddCommand : Orleans.IGrainWithIntegerKey
    {
        Task<IInvoiceView> InvoiceAdd(IInvoiceAdd invoiceAdd);
    }
}

