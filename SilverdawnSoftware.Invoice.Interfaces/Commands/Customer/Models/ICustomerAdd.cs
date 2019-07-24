// ALLOWOVERWRITE-F9D98E476500B9E31BA7CEDDFF272671

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customer.Models
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

         IAddressView  Address   { get; set; }
	}
}


