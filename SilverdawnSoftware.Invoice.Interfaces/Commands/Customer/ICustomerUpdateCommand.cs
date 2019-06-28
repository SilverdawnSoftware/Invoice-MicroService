// ALLOWOVERWRITE-9AA2F124716E263FC9F378C39E12D71B-C4B0CA9F9269EEF0F3F4CB1E4AFC2215
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customer.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customer 
{
    public partial interface ICustomerUpdateCommand : Orleans.IGrainWithIntegerKey
    {
        Task<ICustomerView> CustomerUpdate(ICustomerUpdate customerUpdate);			
    }
}

