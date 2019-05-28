// ALLOWOVERWRITE-564D5459931B34816D210E131B2A1B73
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
                   customer.CustomerExteranlRef=customerAdd.CustomerExteranlRef;  	
                   customer.EmalAddress=customerAdd.EmalAddress;  	
                   customer.IsCompany=customerAdd.IsCompany;  	
                   customer.Name=customerAdd.Name;  	
                   customer.PhoneNumber=customerAdd.PhoneNumber;  	
                   customer.TaxNo=customerAdd.TaxNo;  	
                   await db.SaveChangesAsync();

                   result.Active=customer.Active;
                   result.CustomerExteranlRef=customer.CustomerExteranlRef;
                   result.CustomerId=customer.CustomerId;
                   result.EmalAddress=customer.EmalAddress;
                   result.EntityId=entity.EntityId;
                   result.IsCompany=customer.IsCompany;
                   result.Name=customer.Name;
                   result.PhoneNumber=customer.PhoneNumber;
                   result.TaxNo=customer.TaxNo;
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
