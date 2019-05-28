// ALLOWOVERWRITE-8B8D6A6A2BFB90EBD4F0A954B193CF02
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
  	public partial class AddressAddCommand : Orleans.Grain , IAddressAddCommand
    {

		
      public async Task<IAddressView> AddressAdd(IAddressAdd addressAdd)
      {
			try
          {
              var result=new AddressView();
              using (var db=new InvoiceContext())
              {
                   var address = new Database.Address();
                   if (!db.Customers.Any(w=>w.CustomerId == addressAdd.CustomerId))				
                       return new AddressView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to find parent for Customer",__CQRSStatusCode = 404}; 

                   var customer=db.Customers.First(w=>w.CustomerId == addressAdd.CustomerId);				
                   if (customer.Addresss == null) customer.Addresss = new List<Database.Address>();
                   customer.Addresss.Add(address);
                   address.AddresLine2=addressAdd.AddresLine2;  	
                   address.AddressExternalRef=addressAdd.AddressExternalRef;  	
                   address.AddressLine1=addressAdd.AddressLine1;  	
                   address.AddressLine3=addressAdd.AddressLine3;  	
                   address.City=addressAdd.City;  	
                   address.Country=addressAdd.Country;  	
                   address.PostZipCode=addressAdd.PostZipCode;  	
                   address.StateCounty=addressAdd.StateCounty;  	
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
          catch (Exception e)
                {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    return new AddressView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create AddressView",__CQRSStatusCode = 500};             
                } 
           }
	}



}
