// ALLOWOVERWRITE-834A9A83FE5AC60F59ECC9BC3BB8A0C4


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SilverdawnSoftware.Invoice.CQRS.Commands
{
	[DataContract]
    public partial class UpdateInvoice
    {    
		[DataMember]
		public int InvoiceId  { get; set; } 
		
		[DataMember]
		public DateTime CreatedDate  { get; set; } 
		
		[DataMember]
		public DateTime DueDate  { get; set; } 
		
		[DataMember]
		public DateTime PaidDate  { get; set; } 
		
		[DataMember]
		public decimal GrandTotal  { get; set; } 
		
		[DataMember]
		public decimal SubTotal  { get; set; } 
		
		[DataMember]
		public decimal Tax  { get; set; } 
		
		[DataMember]
		public string OrderedBy  { get; set; } 
		
		[DataMember]
		public string PurchaseOrderRef  { get; set; } 
		
		[DataMember]
		public int InvoiceNo  { get; set; } 
		
		[DataMember]
		public double PaidAmount  { get; set; } 
		
		[DataMember]
		public double PaidTax  { get; set; } 
		
		[DataMember]
		public bool InvoiceEmailed  { get; set; } 
		
		[DataMember]
		public string EmailTo  { get; set; } 
		
		[DataMember]
		public Address BillngAddress  { get; set; } 
		
		[DataMember]
		public string ShippingAddress  { get; set; } 
		
		[DataMember]
		public string TermsAndConditions   { get; set; } 
		
		[DataMember]
		public string PaymentDetails  { get; set; } 
		
    	
    	
    }
}
