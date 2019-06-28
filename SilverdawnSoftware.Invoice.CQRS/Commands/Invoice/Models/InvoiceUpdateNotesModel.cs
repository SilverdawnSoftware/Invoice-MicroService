// ALLOWOVERWRITE-584453F6CC4005A2B0E9A128D16F3F9E-C258BD50AF7FEE8048F2738836E1D335

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models
{
	[DataContract]
    public partial class InvoiceUpdateNotes : CQRSBase, IInvoiceUpdateNotes
    { 
        [DataMember]	
        public int InvoiceId  { get; set; }
		  	
        [DataMember]	
        public string Notes  { get; set; }
		  	
    	 public InvoiceUpdateNotes()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceUpdateNotes";
        }	
	}
}

