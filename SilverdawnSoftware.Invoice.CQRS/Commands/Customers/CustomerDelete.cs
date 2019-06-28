// ALLOWOVERWRITE-BCDAB1B0A64B1EC78C2BAEA5E20543FB-2D212D0D088260E6E24C3E4C7302440C
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customer;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customer.Models;
using SilverdawnSoftware.Invoice.Interfaces;
using SilverdawnSoftware.Invoice.Database;


namespace SilverdawnSoftware.Invoice.CQRS.Commands.Customer
{
  	public partial class CustomerDeleteCommand : Orleans.Grain , ICustomerDeleteCommand
    {

		
      public async Task<ICQRSBase> CustomerDelete(ICustomerDelete customerDelete)
      {
          var result=new CQRSBase();
			try
          {
              using (var db=new InvoiceContext())
              {
                   if (db.Customers.Any(w =>  w.CustomerId == customerDelete.CustomerId))
                   {
                       var customer = db.Customers.First(w =>  w.CustomerId == customerDelete.CustomerId);
                       db.Customers.Remove(customer);
                       await db.SaveChangesAsync();
		
                      result.__CQRSSuccessful=true; 
						return result;
                   }
                   else
                   {
                    result.__CQRSSuccessful=false;
                    result.__CQRSErrorMessage="Customer was not found";
                   }
               }
           }
           catch (Exception e)
               {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);                 
                    return new CQRSBase(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to delete Customer",__CQRSStatusCode = 500};
                }  
                return result;      
           }
	}



}
