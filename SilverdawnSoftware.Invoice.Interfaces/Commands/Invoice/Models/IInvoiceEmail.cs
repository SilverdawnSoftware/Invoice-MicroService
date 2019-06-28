// ALLOWOVERWRITE-812EA5A4600771DECC5C0952592B88FC-8D8BFB901ED874501B7C35ACEEF4CE4C

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models
{
    public partial interface IInvoiceEmail : ICQRSBase
    { 

         int InvoiceId  { get; set; } 	
	}
}


