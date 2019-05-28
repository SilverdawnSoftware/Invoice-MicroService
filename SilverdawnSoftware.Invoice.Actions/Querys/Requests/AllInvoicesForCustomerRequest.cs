// ALLOWOVERWRITE-2197EDAD593E9720FAFE0C3C7B6A91E0


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests
{
	[DataContract]
    public partial class AllInvoicesForCustomerRequest
    {    
		[DataMember]
		public int CustomerId  { get; set; } 
		
    	
    	
    }
}
