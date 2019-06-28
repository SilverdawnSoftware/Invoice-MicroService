// ALLOWOVERWRITE-81EFB07EA3E2E401AD6988220B8C369E-DDD245939C71A1AECFE34CEC04AAFF00

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models
{
    public partial interface IInvoiceDelete : ICQRSBase
    { 

         int InvoiceId  { get; set; } 	
	}
}


