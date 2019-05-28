// ALLOWOVERWRITE-2DA7A966785FB68B932616240E13A9D1


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SilverdawnSoftware.Invoice.CQRS.Commands
{
	[DataContract]
    public partial class CreateInvoiceLine
    {    
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
		
		[DataMember]
		public int InvoiceId  { get; set; } 
		
    	
    	
    }
}
