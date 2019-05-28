// ALLOWOVERWRITE-78A639D3C5ED1301048D1623A325339F

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models
{
	[DataContract]
    public partial class InvoiceCancel : CQRSBase, IInvoiceCancel
    { 
        [DataMember]	
        public int InvoiceId  { get; set; }
		  	
        [DataMember]	
        public string Reason  { get; set; }
		  	
    	 public InvoiceCancel()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceCancel";
        }	
	}
}

