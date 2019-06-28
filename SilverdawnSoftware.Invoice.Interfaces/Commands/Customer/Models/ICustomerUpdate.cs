// ALLOWOVERWRITE-7B932BB6B555C2ABD8A07762C5713943-930DC6155FC346ACDC55CA8E6976A1AB

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
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

         IAddressView  Address   { get; set; }
	}
}


