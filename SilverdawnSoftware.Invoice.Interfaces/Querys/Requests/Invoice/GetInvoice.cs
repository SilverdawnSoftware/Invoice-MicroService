// ALLOWOVERWRITE-390F412D2485A5A32155FEC1FDB27669
using System.Collections.Generic;
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice 
{
    public partial interface IGetInvoiceRequest : Orleans.IGrainWithIntegerKey
    {
        Task<IInvoiceView> GetInvoice(IGetInvoice getInvoice);			
    }
}


