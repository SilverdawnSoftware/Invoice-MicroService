// ALLOWOVERWRITE-E0A85378E1ED372139488C840D5417A0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models
{
    public partial interface IInvoiceChangeStatus : ICQRSBase
    { 

         int InvoiceId  { get; set; } 	

         int Status  { get; set; } 	
	}
}


