// ALLOWOVERWRITE-4A5FA520C74720C604B4A83463169918
using System.Collections.Generic;
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Entity.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Entity 
{
    public partial interface ISearchEntityByNameRequest : Orleans.IGrainWithIntegerKey
    {
        Task<List<IEntityView>> SearchEntityByName(ISearchEntityByName searchEntityByName);
    }
}


