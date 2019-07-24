// ALLOWOVERWRITE-9390E32B3035C4A8F999F4373972DCCC

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models
{
    public partial interface IInvoicePay : ICQRSBase
    { 
         int InvoiceId  { get; set; }
		  	
         double PaidAmount  { get; set; }
		  	
         double PaidTax  { get; set; }
		  	
	}
}

