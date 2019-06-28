// ALLOWOVERWRITE-5C3A37FB3136C4294E07DE69CFA4B10F
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
                   if (entityAdd.Address == null)
                   {
                       entity.Address = new Address();
                   }
                   else
                   {
                       entity.Address=new Address()
                       {	
                           AddresLine2=entityAdd.Address.AddresLine2,                       			
                           AddressExternalRef=entityAdd.Address.AddressExternalRef,                       			
                           AddressLine1=entityAdd.Address.AddressLine1,                       			
                           AddressLine3=entityAdd.Address.AddressLine3,                       			
                           City=entityAdd.Address.City,                       			
                           Country=entityAdd.Address.Country,                       			
                           PostZipCode=entityAdd.Address.PostZipCode,                       			
                           StateCounty=entityAdd.Address.StateCounty,                       			
                       };
                   }
                   entity.EntityExternalRef=entityAdd.EntityExternalRef;  	
                   entity.LogoURL=entityAdd.LogoURL;  	
                   entity.Name=entityAdd.Name;  	
                   entity.SMTPEmailDisplayName=entityAdd.SMTPEmailDisplayName;  	
                   entity.SMTPEmailFromAddress=entityAdd.SMTPEmailFromAddress;  	
                   entity.SMTPHost=entityAdd.SMTPHost;  	
                   entity.SMTPPassword=entityAdd.SMTPPassword;  	
                   entity.SMTPUserName=entityAdd.SMTPUserName;  	
                   //UserCodeBlockStart-PreSave
                   
                   //UserCodeBlockEnd-PreSave
                   await db.SaveChangesAsync();

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
                   //UserCodeBlockStart-PreResult
                   //UserCodeBlockEnd-PreResult
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

