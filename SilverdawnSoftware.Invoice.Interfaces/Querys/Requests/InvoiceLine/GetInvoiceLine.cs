// ALLOWOVERWRITE-E8D1A23A509EBEB0C02DD1510ED333F6
using System.Collections.Generic;
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.InvoiceLine.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.InvoiceLine 
{
    public partial interface IGetInvoiceLineRequest : Orleans.IGrainWithIntegerKey
    {
        Task<IInvoiceLineView> GetInvoiceLine(IGetInvoiceLine getInvoiceLine);			
    }
}


