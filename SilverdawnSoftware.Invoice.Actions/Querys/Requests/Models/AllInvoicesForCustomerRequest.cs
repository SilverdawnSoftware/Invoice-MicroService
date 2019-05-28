// ALLOWOVERWRITE-4AF00C038F3B54950E3A1858426E54EA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Models 
{
	[DataContract]
    public partial class AllInvoicesForCustomerRequest : CQRSBase,IAllInvoicesForCustomerRequest
    { 
        [DataMember]
        public int CustomerId  { get; set; }
		  	
    	 public AllInvoicesForCustomerRequest()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Requests.AllInvoicesForCustomerRequest";
        }	
	}
}

