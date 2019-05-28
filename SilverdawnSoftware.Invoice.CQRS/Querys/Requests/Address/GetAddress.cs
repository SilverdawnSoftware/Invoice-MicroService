// ALLOWOVERWRITE-7EA368F00DB670AE80BB650F8264858E

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Address.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Address;
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Database;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Address
{
    public partial class GetAddressRequest : Orleans.Grain , IGetAddressRequest
    {
   		public async  Task<IAddressView>  GetAddress(IGetAddress getAddress)
   		{
   			try
	            {
	            var result=new AddressView();
	            using (var db=new InvoiceContext())
	            {
	                if (await db.Addresss.AnyAsync(w =>  w.AddressId == getAddress.AddressId))
	                {
	                    var address = await db.Addresss.FirstAsync(w =>  w.AddressId == getAddress.AddressId);
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
                    else
                    {
                    return new AddressView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to find item",__CQRSStatusCode = 500};                                  
                    }
	            }
	            }
	            catch (Exception e)
	            {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    return new AddressView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create AddressView",__CQRSStatusCode = 500};             
	            }
   			}
   		
    }    
}




