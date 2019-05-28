// ALLOWOVERWRITE-9631BB4022C588096B4FF06E837B7ED8


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SilverdawnSoftware.Invoice.CQRS.Commands
{
	[DataContract]
    public partial class CreateInvoice
    {    
		[DataMember]
		public DateTime CreatedDate  { get; set; } 
		
		[DataMember]
		public DateTime DueDate  { get; set; } 
		
		[DataMember]
		public string OrderedBy  { get; set; } 
		
		[DataMember]
		public string PurchaseOrderRef  { get; set; } 
		
		[DataMember]
		public string EmailTo  { get; set; } 
		
		[DataMember]
		public int BillingAddress  { get; set; } 
		
		[DataMember]
		public int ShippingAddressId  { get; set; } 
		
		[DataMember]
		public string TermsAndConditions   { get; set; } 
		
		[DataMember]
		public string PaymentDetails  { get; set; } 
		
    	
    	
    }
}
