// ALLOWOVERWRITE-BCB7579379A8380E56FCFA273FBFA9D5-664151CD66E5E8977E3119B26975504D
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customer.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customer 
{
    public partial interface ICustomerAddCommand : Orleans.IGrainWithIntegerKey
    {
        Task<ICustomerView> CustomerAdd(ICustomerAdd customerAdd);
    }
}

