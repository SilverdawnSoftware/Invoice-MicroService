// ALLOWOVERWRITE-D3A01E1EC4D1704E75985E95120377FA
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice 
{
    public partial interface IInvoiceUpdateTotalsCommand : Orleans.IGrainWithIntegerKey
    {
    }
}

