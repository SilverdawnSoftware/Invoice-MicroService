// ALLOWOVERWRITE-C6691C9864C07E68FE5036B7311198ED


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SilverdawnSoftware.Invoice.CQRS.Commands
{
	[DataContract]
    public partial class CancelInvoice
    {    
		[DataMember]
		public int InvoiceId  { get; set; } 
		
		[DataMember]
		public string Reason  { get; set; } 
		
    	
    	
    }
}
