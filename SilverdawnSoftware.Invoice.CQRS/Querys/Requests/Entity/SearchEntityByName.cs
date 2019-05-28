// ALLOWOVERWRITE-63B5C5650760CA76E498CA46947B8278

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
    public partial class SearchEntityByNameRequest : Orleans.Grain , ISearchEntityByNameRequest
    {
   		public async Task<List<IEntityView>> SearchEntityByName(ISearchEntityByName searchEntityByName)
   		{
            var result=new List<IEntityView>();
             try
               {
                using (var db=new InvoiceContext())
                   {	            
                      var entitys = await db.Entitys.Where(w=> w.Name == searchEntityByName.Name).ToListAsync();
		             	foreach(var entity in entitys)
				     	{
				      		var toAdd=new EntityView();
                            toAdd.EntityExternalRef=entity.EntityExternalRef;
                            toAdd.EntityId=entity.EntityId;
                            toAdd.LogoURL=entity.LogoURL;
                            toAdd.Name=entity.Name;
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




