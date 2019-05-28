// ALLOWOVERWRITE-E0AEC5B3A605CF542C58DF6C391E5886

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models 
{
    public partial interface IAddressView : ICQRSBase
    { 
         int AddressId  { get; set; }
		  	
         string AddressLine1  { get; set; }
		  	
         string AddresLine2  { get; set; }
		  	
         string City  { get; set; }
		  	
         string PostZipCode  { get; set; }
		  	
         string StateCounty  { get; set; }
		  	
         string Country  { get; set; }
		  	
         string AddressExternalRef  { get; set; }
		  	
         string AddressLine3  { get; set; }
		  	
	}
}



