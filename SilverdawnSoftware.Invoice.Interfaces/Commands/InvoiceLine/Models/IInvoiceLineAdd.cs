// ALLOWOVERWRITE-04446514990562507D3D1AD5072F509F

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.InvoiceLine.Models
{
    public partial interface IInvoiceLineAdd : ICQRSBase
    { 
         double Quantity  { get; set; }
		  	
         decimal UnitCost  { get; set; }
		  	
         decimal SubTotal  { get; set; }
		  	
         decimal TaxTotal  { get; set; }
		  	
         decimal LineTotal  { get; set; }
		  	
         string Product  { get; set; }
		  	
         bool TaxExempt  { get; set; }
		  	
         string ProductCode  { get; set; }
		  	
         string Notes  { get; set; }
		  	
         int InvoiceId  { get; set; }
		  	
	}
}

