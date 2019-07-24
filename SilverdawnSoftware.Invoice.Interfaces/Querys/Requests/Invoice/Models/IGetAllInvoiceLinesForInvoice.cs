// ALLOWOVERWRITE-1247FA7784AD035478C366D438DFA8AA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice.Models 
{
    public partial interface IGetAllInvoiceLinesForInvoice : ICQRSBase
    { 
         int InvoiceNo  { get; set; }
		  	
	}
}



