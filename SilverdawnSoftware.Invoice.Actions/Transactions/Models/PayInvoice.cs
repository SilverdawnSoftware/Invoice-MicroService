// ALLOWOVERWRITE-E7E68990120B3BF78738A90EC1093BA0


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SilverdawnSoftware.Invoice.CQRS.Commands
{
	[DataContract]
    public partial class PayInvoice
    {    
		[DataMember]
		public int InvoiceId  { get; set; } 
		
		[DataMember]
		public double PaidAmount  { get; set; } 
		
		[DataMember]
		public double PaidTax  { get; set; } 
		
    	
    	
    }
}
