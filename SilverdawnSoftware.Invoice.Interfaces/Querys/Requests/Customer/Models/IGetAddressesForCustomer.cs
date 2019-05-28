// ALLOWOVERWRITE-621F099D4E49EB54331CC2ABA079FB93

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer.Models 
{
    public partial interface IGetAddressesForCustomer : ICQRSBase
    { 
         int CustomerId  { get; set; }
		  	
	}
}



