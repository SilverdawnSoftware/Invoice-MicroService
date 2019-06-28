// ALLOWOVERWRITE-CF2C3B0C388557F7EE778644765002C6-C26611D6D402917932C54E6A5B7C25BB
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
using SilverdawnSoftware.Invoice.Database;


namespace SilverdawnSoftware.Invoice.CQRS.Commands.Entity
{
  	public partial class EntityDeleteCommand : Orleans.Grain , IEntityDeleteCommand
    {

		
      public async Task<ICQRSBase> EntityDelete(IEntityDelete entityDelete)
      {
          var result=new CQRSBase();
			try
          {
              using (var db=new InvoiceContext())
              {
                   if (db.Entitys.Any(w =>  w.EntityId == entityDelete.EntityId))
                   {
                       var entity = db.Entitys.First(w =>  w.EntityId == entityDelete.EntityId);
                       db.Entitys.Remove(entity);
                       await db.SaveChangesAsync();
		
                      result.__CQRSSuccessful=true; 
						return result;
                   }
                   else
                   {
                    result.__CQRSSuccessful=false;
                    result.__CQRSErrorMessage="Entity was not found";
                   }
               }
           }
           catch (Exception e)
               {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);                 
                    return new CQRSBase(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to delete Entity",__CQRSStatusCode = 500};
                }  
                return result;      
           }
	}



}
