// ALLOWOVERWRITE-44EB335E784DB7D4958130F76613C815


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests
{
	[DataContract]
    public partial class InvoiceViewRequest
    {    
		[DataMember]
		public int InvoiceNo  { get; set; } 
		
    	
    	
    }
}
