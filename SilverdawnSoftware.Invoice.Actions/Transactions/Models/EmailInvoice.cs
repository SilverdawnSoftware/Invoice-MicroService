// ALLOWOVERWRITE-0E44FA0ADEB5A60949824BFA5ED61398


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SilverdawnSoftware.Invoice.CQRS.Commands
{
	[DataContract]
    public partial class EmailInvoice
    {    
		[DataMember]
		public int InvoiceId  { get; set; } 
		
    	
    	
    }
}
