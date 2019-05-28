// ALLOWOVERWRITE-324D252B7D8F87FE15585BB34516F57A

using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer;
using SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
using SilverdawnSoftware.Invoice.Database;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Customer
{
    public partial class SearchForCustomerByNameRequest : Orleans.Grain , ISearchForCustomerByNameRequest
    {
   		public async  Task<ICustomerView>  SearchForCustomerByName(ISearchForCustomerByName searchForCustomerByName)
   		{
   			try
	            {
	            var result=new CustomerView();
	            using (var db=new InvoiceContext())
	            {
	                if (await db.Customers.AnyAsync(w =>  w.Name == searchForCustomerByName.Name))
	                {
	                   var customer = await db.Customers.FirstAsync(w =>  w.Name == searchForCustomerByName.Name);
                       result.Active=customer.Active;
                       result.CustomerExteranlRef=customer.CustomerExteranlRef;
                       result.CustomerId=customer.CustomerId;
                       result.EmalAddress=customer.EmalAddress;
                       result.EntityId=customer.Entity.EntityId;
                       result.IsCompany=customer.IsCompany;
                       result.Name=customer.Name;
                       result.PhoneNumber=customer.PhoneNumber;
                       result.TaxNo=customer.TaxNo;
				       return result;
	                }
                    else
                    {
                    return new CustomerView(){__CQRSSuccessful = false,__CQRSErrorMessage = "Unable to find item",__CQRSStatusCode = 500};                                  
                    }
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




