// ALLOWOVERWRITE-2186A33113483566BCB6B21118F57E26-F8D3568EFD2762B64BCDF6E48DF3C752
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice 
{
    public partial interface IInvoiceDeleteCommand : Orleans.IGrainWithIntegerKey
    {
        Task<ICQRSBase> InvoiceDelete(IInvoiceDelete invoiceDelete);			
    }
}

