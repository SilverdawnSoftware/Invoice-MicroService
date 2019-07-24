// ALLOWOVERWRITE-D0A56D05673CBEBE06D8572113CAE644

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models 
{
    public partial interface IAddressView : ICQRSBase
    { 
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



