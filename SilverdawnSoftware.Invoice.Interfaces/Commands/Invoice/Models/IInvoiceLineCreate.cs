// ALLOWOVERWRITE-F7C010017EA6EBA32D3C561C5E39F718

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.InvoiceLine.Models
{
    public partial interface IInvoiceLineCreate : ICQRSBase
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

