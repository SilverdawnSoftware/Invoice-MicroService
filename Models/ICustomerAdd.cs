// ALLOWOVERWRITE-7991020D7A5C7D87BACF679E1A86053C

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customers.Models
{
    public partial interface ICustomerAdd : ICQRSBase
    { 
         string Name  { get; set; }
		  	
         string PhoneNumber  { get; set; }
		  	
         string EmalAddress  { get; set; }
		  	
         bool Active  { get; set; }
		  	
         bool IsCompany  { get; set; }
		  	
         string CustomerExteranlRef  { get; set; }
		  	
         string TaxNo  { get; set; }
		  	
         int EntityId  { get; set; }
		  	
	}
}

