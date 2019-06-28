// ALLOWOVERWRITE-A507BE34F56E95F3A411E6374D337F33-7A5B31AC01EA1A7D949AC3253C763416
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
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Database;


namespace SilverdawnSoftware.Invoice.CQRS.Commands.Customer
{
  	public partial class CustomerUpdateCommand : Orleans.Grain , ICustomerUpdateCommand
    {

		
      public async Task<ICustomerView> CustomerUpdate(ICustomerUpdate customerUpdate)
      {
			try
          {
              var result=new CustomerView();
              using (var db=new InvoiceContext())
              {
                   if (db.Customers.Any(w =>  w.CustomerId == customerUpdate.CustomerId))
                   {
                       var customer = db.Customers.First(w =>  w.CustomerId == customerUpdate.CustomerId);
                    customer.Active=customerUpdate.Active;  	
                    customer.CustomerExteranlRef=customerUpdate.CustomerExteranlRef;  	
                    customer.EmailAddress=customerUpdate.EmalAddress;  	
                    customer.IsCompany=customerUpdate.IsCompany;  	
                    customer.Name=customerUpdate.Name;  	
                    customer.PhoneNumber=customerUpdate.PhoneNumber;  	
                    customer.TaxNo=customerUpdate.TaxNo;  	
                       await db.SaveChangesAsync();

                       result.Active=customer.Active;
                       result.CustomerExteranlRef=customer.CustomerExteranlRef;
                       result.CustomerId=customer.CustomerId;
                       result.EmalAddress=customer.EmailAddress;
                       result.IsCompany=customer.IsCompany;
                       result.Name=customer.Name;
                       result.PhoneNumber=customer.PhoneNumber;
                       result.TaxNo=customer.TaxNo;
                       return result;
                   }
               }
           }
              catch (Exception e)
                {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    return new CustomerView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create CustomerView",__CQRSStatusCode = 500};     
                } 
               return null;         
               }
	}



}
