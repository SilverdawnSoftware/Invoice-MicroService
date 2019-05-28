// ALLOWOVERWRITE-5DFD6F0C627CDBA30FB2165C78DB3722


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SilverdawnSoftware.Invoice.CQRS.Commands
{
	[DataContract]
    public partial class DeleteInvoiceLine
    {    
		[DataMember]
		public int InvoiceLineId  { get; set; } 
		
    	
    	
    }
}
