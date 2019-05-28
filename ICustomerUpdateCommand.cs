// ALLOWOVERWRITE-FAE079F0F0CA634CAC473A08BDD6B30C
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customers.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customers 
{
    public partial interface ICustomerUpdateCommand : Orleans.IGrainWithIntegerKey
    {
        Task<ICustomerView> CustomerUpdate(ICustomerUpdate customerUpdate);			
    }
}

