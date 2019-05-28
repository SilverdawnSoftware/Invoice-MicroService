// ALLOWOVERWRITE-88E861B3973EBF016E1AF2155E032214

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Models 
{
	[DataContract]
    public partial class InvoiceViewRequest : CQRSBase,IInvoiceViewRequest
    { 
        [DataMember]
        public int InvoiceNo  { get; set; }
		  	
    	 public InvoiceViewRequest()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Requests.InvoiceViewRequest";
        }	
	}
}

