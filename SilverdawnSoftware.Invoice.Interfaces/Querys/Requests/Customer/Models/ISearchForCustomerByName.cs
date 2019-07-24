// ALLOWOVERWRITE-B6DB558232C9A5539BF3C5B7F321CF98

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer.Models 
{
    public partial interface ISearchForCustomerByName : ICQRSBase
    { 
         string Name  { get; set; }
		  	
	}
}



