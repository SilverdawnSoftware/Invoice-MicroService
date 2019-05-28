// ALLOWOVERWRITE-7A95A648319939A22845AB81AADDAFEA


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SilverdawnSoftware.Invoice.CQRS.Commands
{
	[DataContract]
    public partial class DeleteInvoice
    {    
		[DataMember]
		public int InvoiceId  { get; set; } 
		
    	
    	
    }
}
