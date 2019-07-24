// ALLOWOVERWRITE-9E366AF86321D2CA4AC72E672AB44CAC

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Entity.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Entity;
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Database;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Entity
{
    public partial class GetEntityRequest : Orleans.Grain , IGetEntityRequest
    {
   		public async  Task<IEntityView>  GetEntity(IGetEntity getEntity)
   		{
   			try
	            {
	            var result=new EntityView();
	            using (var db=new InvoiceContext())
	            {
	                if (await db.Entitys.AnyAsync(w =>  w.EntityId == getEntity.EntityId))
	                {
	                   var entity = await db.Entitys.FirstAsync(w =>  w.EntityId == getEntity.EntityId);
                       result.Address = new AddressView();
                       result.Address.AddresLine2=entity.Address.AddresLine2;                       			
                       result.Address.AddressExternalRef=entity.Address.AddressExternalRef;                       			
                       result.Address.AddressLine1=entity.Address.AddressLine1;                       			
                       result.Address.AddressLine3=entity.Address.AddressLine3;                       			
                       result.Address.City=entity.Address.City;                       			
                       result.Address.Country=entity.Address.Country;                       			
                       result.Address.PostZipCode=entity.Address.PostZipCode;                       			
                       result.Address.StateCounty=entity.Address.StateCounty;                       			
                       result.EntityExternalRef=entity.EntityExternalRef;
                       result.EntityId=entity.EntityId;
                       result.LogoURL=entity.LogoURL;
                       result.Name=entity.Name;
                       result.SMTPEmailDisplayName=entity.SMTPEmailDisplayName;
                       result.SMTPEmailFromAddress=entity.SMTPEmailFromAddress;
                       result.SMTPHost=entity.SMTPHost;
                       result.SMTPPassword=entity.SMTPPassword;
                       result.SMTPUserName=entity.SMTPUserName;
				       return result;
	                }
                    else
                    {
                    return new EntityView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to find item",__CQRSStatusCode = 500};                                  
                    }
	            }
	            }
	            catch (Exception e)
	            {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    return new EntityView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create EntityView",__CQRSStatusCode = 500};             
	            }
   			}
   		
    }    
}




