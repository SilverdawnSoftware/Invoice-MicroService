// ALLOWOVERWRITE-C7A5E85B52D6333C745104A098E39F75
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
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Database;


namespace SilverdawnSoftware.Invoice.CQRS.Commands.Address
{
  	public partial class AddressUpdateCommand : Orleans.Grain , IAddressUpdateCommand
    {

		
      public async Task<IAddressView> AddressUpdate(IAddressUpdate addressUpdate)
      {
			try
          {
              var result=new AddressView();
              using (var db=new InvoiceContext())
              {
                   if (db.Addresss.Any(w =>  w.AddressId == addressUpdate.AddressId))
                   {
                       var address = db.Addresss.First(w =>  w.AddressId == addressUpdate.AddressId);
                    address.AddresLine2=addressUpdate.AddresLine2;  	
                    address.AddressExternalRef=addressUpdate.AddressExternalRef;  	
                    address.AddressLine1=addressUpdate.AddressLine1;  	
                    address.AddressLine3=addressUpdate.AddressLine3;  	
                    address.City=addressUpdate.City;  	
                    address.Country=addressUpdate.Country;  	
                    address.PostZipCode=addressUpdate.PostZipCode;  	
                    address.StateCounty=addressUpdate.StateCounty;  	
                       await db.SaveChangesAsync();

                       result.AddresLine2=address.AddresLine2;
                       result.AddressExternalRef=address.AddressExternalRef;
                       result.AddressId=address.AddressId;
                       result.AddressLine1=address.AddressLine1;
                       result.AddressLine3=address.AddressLine3;
                       result.City=address.City;
                       result.Country=address.Country;
                       result.PostZipCode=address.PostZipCode;
                       result.StateCounty=address.StateCounty;
                       return result;
                   }
               }
           }
              catch (Exception e)
                {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    return new AddressView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create AddressView",__CQRSStatusCode = 500};     
                } 
               return null;         
               }
	}



}
