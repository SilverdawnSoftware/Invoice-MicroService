// ALLOWOVERWRITE-0B71940CFA94BDE9E24A32D32360BD4B
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customers.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customers 
{
    public partial interface ICustomerAddCommand : Orleans.IGrainWithIntegerKey
    {
        Task<ICustomerView> CustomerAdd(ICustomerAdd customerAdd);
    }
}

