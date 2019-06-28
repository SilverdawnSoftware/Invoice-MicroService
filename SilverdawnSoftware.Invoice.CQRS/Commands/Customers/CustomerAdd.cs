// ALLOWOVERWRITE-89DF4D31A248EE2CA91B33F41AC9CE2B
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
  	public partial class CustomerAddCommand : Orleans.Grain , ICustomerAddCommand
    {

		
      public async Task<ICustomerView> CustomerAdd(ICustomerAdd customerAdd)
      {
			try
          {
              var result=new CustomerView();
              using (var db=new InvoiceContext())
              {
                   var customer = new Database.Customer();
                   if (!db.Entitys.Any(w=>w.EntityId == customerAdd.EntityId))				
                       return new CustomerView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to find parent for Entity",__CQRSStatusCode = 404}; 

                   var entity=db.Entitys.First(w=>w.EntityId == customerAdd.EntityId);				
                   if (entity.Customers == null) entity.Customers = new List<Database.Customer>();
                   entity.Customers.Add(customer);
                   customer.Active=customerAdd.Active;  	
                   if (customerAdd.Address == null)
                   {
                       customer.Address = new Address();
                   }
                   else
                   {
                       customer.Address=new Address()
                       {	
                           AddresLine2=customerAdd.Address.AddresLine2,                       			
                           AddressExternalRef=customerAdd.Address.AddressExternalRef,                       			
                           AddressLine1=customerAdd.Address.AddressLine1,                       			
                           AddressLine3=customerAdd.Address.AddressLine3,                       			
                           City=customerAdd.Address.City,                       			
                           Country=customerAdd.Address.Country,                       			
                           PostZipCode=customerAdd.Address.PostZipCode,                       			
                           StateCounty=customerAdd.Address.StateCounty,                       			
                       };
                   }
                   customer.CustomerExteranlRef=customerAdd.CustomerExteranlRef;  	
                   customer.EmailAddress=customerAdd.EmalAddress;  	
                   customer.IsCompany=customerAdd.IsCompany;  	
                   customer.Name=customerAdd.Name;  	
                   customer.PhoneNumber=customerAdd.PhoneNumber;  	
                   customer.TaxNo=customerAdd.TaxNo;  	
                   //UserCodeBlockStart-PreSave
                   //UserCodeBlockEnd-PreSave
                   await db.SaveChangesAsync();

                   result.Active=customer.Active;
                   result.CustomerExteranlRef=customer.CustomerExteranlRef;
                   result.CustomerId=customer.CustomerId;
                   result.EmalAddress=customer.EmailAddress;
                   result.EntityId=entity.EntityId;
                   result.IsCompany=customer.IsCompany;
                   result.Name=customer.Name;
                   result.PhoneNumber=customer.PhoneNumber;
                   result.TaxNo=customer.TaxNo;
                   //UserCodeBlockStart-PreResult
                   //UserCodeBlockEnd-PreResult
                   return result;
               }
           }
          catch (Exception e)
                {
                    LogFactory.GetLogger().Log(LogLevel.Error,e);
                    return new CustomerView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to create CustomerView",__CQRSStatusCode = 500};             
                } 
           }
	}



}

