// ALLOWOVERWRITE-BE28B6E03D12E3F56428D3B55D43933F

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.InvoiceLine.Models 
{
    public partial interface IGetInvoiceLine : ICQRSBase
    { 
         int InvoiceLineId  { get; set; }
		  	
	}
}



