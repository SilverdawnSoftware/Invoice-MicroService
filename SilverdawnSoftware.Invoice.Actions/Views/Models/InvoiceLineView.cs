// ALLOWOVERWRITE-9EFD70E1A34F9EC2A0435E02EADFACF7


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SilverdawnSoftware.Invoice.CQRS.Querys.Models.Models 
{
	[DataContract]
    public partial class InvoiceLineView : CQRSBase
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
		
    	
   	
    	 public InvoiceLineView()
        {
            this.__CQRSCommandName = "SilverdawnSoftware.Invoice.CQRS.Querys.Models.InvoiceLineView";
        }
    }
}
