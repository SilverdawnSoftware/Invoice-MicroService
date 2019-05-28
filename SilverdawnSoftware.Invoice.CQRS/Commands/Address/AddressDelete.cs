// ALLOWOVERWRITE-F6B42E43CB6F3EC872D12A14FD135D05
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Address;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Address.Models;
using SilverdawnSoftware.Invoice.Interfaces;
using SilverdawnSoftware.Invoice.Database;


namespace SilverdawnSoftware.Invoice.CQRS.Commands.Address
{
  	public partial class AddressDeleteCommand : Orleans.Grain , IAddressDeleteCommand
    {

		
      public async Task<ICQRSBase> AddressDelete(IAddressDelete addressDelete)
      {
          var result=new CQRSBase();
			try
          {
              using (var db=new InvoiceContext())
              {
                   if (db.Addresss.Any(w =>  w.AddressId == addressDelete.AddressId))
                   {
                       var address = db.Addresss.First(w =>  w.AddressId == addressDelete.AddressId);
                       db.Addresss.Remove(address);
                       await db.SaveChangesAsync();
		
                      result.__CQRSSuccessful=true; 
						return result;
                   }
                   else
                   {
                    result.__CQRSSuccessful=false;
                    result.__CQRSErrorMessage="Address was not found";
                   }
               }
           }
           catch (Exception e)
               {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);                 
                    return new CQRSBase(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to delete Address",__CQRSStatusCode = 500};
                }  
                return result;      
           }
	}



}
