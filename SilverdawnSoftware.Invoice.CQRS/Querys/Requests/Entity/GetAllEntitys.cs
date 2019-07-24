// ALLOWOVERWRITE-80E09083984C3006EED3598FA1EA0506

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
    public partial class GetAllEntitysRequest : Orleans.Grain , IGetAllEntitysRequest
    {
   		public async Task<List<IEntityView>> GetAllEntitys(IGetAllEntitys getAllEntitys)
   		{
            var result=new List<IEntityView>();
             try
               {
                using (var db=new InvoiceContext())
                   {	            
                      var entitys = await db.Entitys.ToListAsync();
		             	foreach(var entity in entitys)
				     	{
				      		var toAdd=new EntityView();
                            toAdd.Address = new AddressView();
                            toAdd.Address.AddresLine2=entity.Address.AddresLine2;                       			
                            toAdd.Address.AddressExternalRef=entity.Address.AddressExternalRef;                       			
                            toAdd.Address.AddressLine1=entity.Address.AddressLine1;                       			
                            toAdd.Address.AddressLine3=entity.Address.AddressLine3;                       			
                            toAdd.Address.City=entity.Address.City;                       			
                            toAdd.Address.Country=entity.Address.Country;                       			
                            toAdd.Address.PostZipCode=entity.Address.PostZipCode;                       			
                            toAdd.Address.StateCounty=entity.Address.StateCounty;                       			
                            toAdd.EntityExternalRef=entity.EntityExternalRef;
                            toAdd.EntityId=entity.EntityId;
                            toAdd.LogoURL=entity.LogoURL;
                            toAdd.Name=entity.Name;
                            toAdd.SMTPEmailDisplayName=entity.SMTPEmailDisplayName;
                            toAdd.SMTPEmailFromAddress=entity.SMTPEmailFromAddress;
                            toAdd.SMTPHost=entity.SMTPHost;
                            toAdd.SMTPPassword=entity.SMTPPassword;
                            toAdd.SMTPUserName=entity.SMTPUserName;
                            result.Add(toAdd);
						}
	            }
	            return result;
	            }
	            catch (Exception e)
	            {	            
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    result.Clear();
                    return result; 
                   // return new EntityView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create EntityView",__CQRSStatusCode = 500};             
	            }
   			}
   		
    }    
}




