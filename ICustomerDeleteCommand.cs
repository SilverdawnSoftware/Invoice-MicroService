// ALLOWOVERWRITE-82D008627DA175AF6D666C62D76DE2B8
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customers.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customers 
{
    public partial interface ICustomerDeleteCommand : Orleans.IGrainWithIntegerKey
    {
        Task<ICQRSBase> CustomerDelete(ICustomerDelete customerDelete);			
    }
}

