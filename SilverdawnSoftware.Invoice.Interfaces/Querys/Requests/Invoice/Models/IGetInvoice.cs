// ALLOWOVERWRITE-A572D033DFEA5A5BE033541CE4CC6926

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice.Models 
{
    public partial interface IGetInvoice : ICQRSBase
    { 
         int InvoiceNo  { get; set; }
		  	
	}
}



