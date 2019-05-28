// ALLOWOVERWRITE-4910002082BC53CD0B978257E66D5A6E


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SilverdawnSoftware.Invoice.CQRS.Commands
{
	[DataContract]
    public partial class UpdateInvoiceNotes
    {    
		[DataMember]
		public int InvoiceId  { get; set; } 
		
		[DataMember]
		public string Notes  { get; set; } 
		
    	
    	
    }
}
