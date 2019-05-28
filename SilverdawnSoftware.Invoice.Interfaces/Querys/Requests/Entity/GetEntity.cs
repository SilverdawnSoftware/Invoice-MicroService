// ALLOWOVERWRITE-D274CC144833D754930356379B611AF5
using System.Collections.Generic;
using System.Threading.Tasks;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Entity.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Entity 
{
    public partial interface IGetEntityRequest : Orleans.IGrainWithIntegerKey
    {
        Task<IEntityView> GetEntity(IGetEntity getEntity);			
    }
}


