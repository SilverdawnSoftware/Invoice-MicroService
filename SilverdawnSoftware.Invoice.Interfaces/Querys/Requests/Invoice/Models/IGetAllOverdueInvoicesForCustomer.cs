// ALLOWOVERWRITE-FCD546705376D93E69491D86BE90CA28

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice.Models 
{
    public partial interface IGetAllOverdueInvoicesForCustomer : ICQRSBase
    { 
         int CustomerId  { get; set; }
		  	
         DateTime DueDate  { get; set; }
		  	
         double PaidAmount  { get; set; }
		  	
	}
}



