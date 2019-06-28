// ALLOWOVERWRITE-C27700991CC9E7A927314BC090402AA6-09BF857A8F3DC3F15EE7608CA63139D6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models
{
    public partial interface IInvoiceUpdateTotals : ICQRSBase
    { 

         int InvoiceId  { get; set; } 	

         decimal SubTotal  { get; set; } 	

         decimal TaxTotal  { get; set; } 	

         decimal GrandTotal  { get; set; } 	
	}
}


