// ALLOWOVERWRITE-D6560BA31BFEE05E82ADCB30B2D7C6DD-390F412D2485A5A32155FEC1FDB27669
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


