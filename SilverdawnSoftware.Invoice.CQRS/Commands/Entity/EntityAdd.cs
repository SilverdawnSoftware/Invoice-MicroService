// ALLOWOVERWRITE-1FCFED53747D7947421D3902CB5807A5
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity.Models;
using SilverdawnSoftware.Invoice.Interfaces;
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Database;


namespace SilverdawnSoftware.Invoice.CQRS.Commands.Entity
{
  	public partial class EntityAddCommand : Orleans.Grain , IEntityAddCommand
    {

		
      public async Task<IEntityView> EntityAdd(IEntityAdd entityAdd)
      {
			try
          {
              var result=new EntityView();
              using (var db=new InvoiceContext())
              {
                   var entity = new Database.Entity();
                   db.Entitys.Add(entity);
                   entity.EntityExternalRef=entityAdd.EntityExternalRef;  	
                   entity.LogoURL=entityAdd.LogoURL;  	
                   entity.Name=entityAdd.Name;  	
                   await db.SaveChangesAsync();

                   result.EntityExternalRef=entity.EntityExternalRef;
                   result.EntityId=entity.EntityId;
                   result.LogoURL=entity.LogoURL;
                   result.Name=entity.Name;
                   return result;
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
