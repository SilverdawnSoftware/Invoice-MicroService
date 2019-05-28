// ALLOWOVERWRITE-616FCE6946EE85B883DF847F653D961E

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Address.Models
{
    public partial interface IAddressAdd : ICQRSBase
    { 
         string AddressLine1  { get; set; }
		  	
         string AddresLine2  { get; set; }
		  	
         string City  { get; set; }
		  	
         string PostZipCode  { get; set; }
		  	
         string StateCounty  { get; set; }
		  	
         string Country  { get; set; }
		  	
         string AddressExternalRef  { get; set; }
		  	
         string AddressLine3  { get; set; }
		  	
         int CustomerId  { get; set; }
		  	
	}
}

