// ALLOWOVERWRITE-169D31C91B1ED0ECC4773E7A90F4C872-435540D9E4AC65A69514EDF60A049AD8

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer.Models 
{
    public partial interface IGetOutStandingInvoicesForCustomer : ICQRSBase
    { 
         int CustomerId  { get; set; }
		  	
         double PaidAmount  { get; set; }
		  	
	}
}



