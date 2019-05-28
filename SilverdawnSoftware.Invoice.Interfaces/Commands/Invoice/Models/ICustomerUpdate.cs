// ALLOWOVERWRITE-70CD687B4AFEF0919AEC818A86B59DB7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customer.Models
{
    public partial interface ICustomerUpdate : ICQRSBase
    { 
         int CustomerId  { get; set; }
		  	
         string Name  { get; set; }
		  	
         string PhoneNumber  { get; set; }
		  	
         string EmalAddress  { get; set; }
		  	
         bool Active  { get; set; }
		  	
         bool IsCompany  { get; set; }
		  	
         string CustomerExteranlRef  { get; set; }
		  	
         string TaxNo  { get; set; }
		  	
	}
}

