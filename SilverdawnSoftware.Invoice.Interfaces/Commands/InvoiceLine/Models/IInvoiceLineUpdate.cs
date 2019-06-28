// ALLOWOVERWRITE-D9970B0AEDB06735278D159F1F32E4F5-F92B7DF76167ADC0F4B05D1D6A3CBB15

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.InvoiceLine.Models
{
    public partial interface IInvoiceLineUpdate : ICQRSBase
    { 

         int InvoiceLineId  { get; set; } 	

         double Quantity  { get; set; } 	

         decimal UnitCost  { get; set; } 	

         decimal SubTotal  { get; set; } 	

         decimal TaxTotal  { get; set; } 	

         decimal LineTotal  { get; set; } 	

         string Product  { get; set; } 	

         bool TaxExempt  { get; set; } 	

         string ProductCode  { get; set; } 	

         string Notes  { get; set; } 	
	}
}


