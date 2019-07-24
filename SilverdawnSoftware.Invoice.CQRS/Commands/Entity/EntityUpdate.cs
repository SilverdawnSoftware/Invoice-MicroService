// ALLOWOVERWRITE-C28B4249F18A943B82AD69F55A868A0E
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
  	public partial class EntityUpdateCommand : Orleans.Grain , IEntityUpdateCommand
    {


        /// <summary>  </summary>
        /// <param name="invoiceAdd">this is a test</param>
        /// <returns></returns>
        /// <remarks>
        /// ///

        /// </remarks>
      public async Task<IEntityView> EntityUpdate(IEntityUpdate entityUpdate)
      {
			try
          {
              var result=new EntityView();
              using (var db=new InvoiceContext())
              {
                   if (db.Entitys.Any(w =>  w.EntityId == entityUpdate.EntityId))
                   {
                       var entity = db.Entitys.First(w =>  w.EntityId == entityUpdate.EntityId);
                    entity.EntityExternalRef=entityUpdate.EntityExternalRef;  	
                    entity.LogoURL=entityUpdate.LogoURL;  	
                    entity.Name=entityUpdate.Name;  	
                    entity.SMTPEmailDisplayName=entityUpdate.SMTPEmailDisplayName;  	
                    entity.SMTPEmailFromAddress=entityUpdate.SMTPEmailFromAddress;  	
                    entity.SMTPHost=entityUpdate.SMTPHost;  	
                    entity.SMTPPassword=entityUpdate.SMTPPassword;  	
                    entity.SMTPUserName=entityUpdate.SMTPUserName;  	
                       await db.SaveChangesAsync();

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
               }
           }
              catch (Exception e)
                {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    return new EntityView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create EntityView",__CQRSStatusCode = 500};     
                } 
               return null;         
               }
	}



}
