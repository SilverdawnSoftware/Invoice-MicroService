// ALLOWOVERWRITE-78059E21C17724F1A1E7977034F17F39


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SilverdawnSoftware.Invoice.CQRS.Commands
{
	[DataContract]
    public partial class UpdateInvoiceLine
    {    
		[DataMember]
		public int InvoiceLineId  { get; set; } 
		
		[DataMember]
		public double Quantity  { get; set; } 
		
		[DataMember]
		public decimal UnitCost  { get; set; } 
		
		[DataMember]
		public decimal SubTotal  { get; set; } 
		
		[DataMember]
		public decimal TaxTotal  { get; set; } 
		
		[DataMember]
		public decimal LineTotal  { get; set; } 
		
		[DataMember]
		public string Product  { get; set; } 
		
		[DataMember]
		public bool TaxExempt  { get; set; } 
		
		[DataMember]
		public string ProductCode  { get; set; } 
		
		[DataMember]
		public string Notes  { get; set; } 
		
    	
    	
    }
}
