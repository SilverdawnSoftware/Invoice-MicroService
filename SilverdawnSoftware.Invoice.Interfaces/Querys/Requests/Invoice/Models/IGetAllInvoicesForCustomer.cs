// ALLOWOVERWRITE-AF1A2BBB664C1CC5E0EC09EBC3A503FF

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice.Models 
{
    public partial interface IGetAllInvoicesForCustomer : ICQRSBase
    { 
         int CustomerId  { get; set; }
		  	
	}
}



