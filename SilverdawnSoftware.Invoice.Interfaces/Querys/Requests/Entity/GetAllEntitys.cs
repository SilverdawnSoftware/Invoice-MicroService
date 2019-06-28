// ALLOWOVERWRITE-9934D872CB1C7A5471FE1128FF8947C3-5F8F99DD8671C51E2DAD3C49383AF7BE
using System.Collections.Generic;
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Entity.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Entity 
{
    public partial interface IGetAllEntitysRequest : Orleans.IGrainWithIntegerKey
    {
        Task<List<IEntityView>> GetAllEntitys(IGetAllEntitys getAllEntitys);
    }
}


