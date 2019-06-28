// ALLOWOVERWRITE-0EAC9E7D0EAE4C829D8A908DAA510DCB-0BCE369285F33E9C1EE15CA712152005

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models
{
    public partial interface IInvoiceCancel : ICQRSBase
    { 

         int InvoiceId  { get; set; } 	

         string Reason  { get; set; } 	
	}
}


