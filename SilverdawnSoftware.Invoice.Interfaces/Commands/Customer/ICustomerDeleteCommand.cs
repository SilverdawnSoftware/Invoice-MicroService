// ALLOWOVERWRITE-94A6D5013A20B740A3308BFA2BE7E0AD-ACFFC82B556358A415B8A25A86CF9ECD
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customer.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customer 
{
    public partial interface ICustomerDeleteCommand : Orleans.IGrainWithIntegerKey
    {
        Task<ICQRSBase> CustomerDelete(ICustomerDelete customerDelete);			
    }
}

