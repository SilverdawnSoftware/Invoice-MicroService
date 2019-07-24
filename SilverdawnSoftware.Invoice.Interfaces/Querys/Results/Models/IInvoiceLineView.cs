// ALLOWOVERWRITE-BBFB44872F13DDDEB38E94C0AEA1F1C5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models 
{
    public partial interface IInvoiceLineView : ICQRSBase
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



