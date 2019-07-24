// ALLOWOVERWRITE-952574401C55B146375BC9438991B7DA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer.Models 
{
    public partial interface IGetCustomer : ICQRSBase
    { 
         int CustomerId  { get; set; }
		  	
	}
}



