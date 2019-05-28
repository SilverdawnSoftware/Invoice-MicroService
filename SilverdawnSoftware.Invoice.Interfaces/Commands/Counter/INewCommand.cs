// ALLOWOVERWRITE-8558F26F4296801718E316CACE949122
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter 
{
    public partial interface INewCommand : Orleans.IGrainWithIntegerKey
    {
    }
}

