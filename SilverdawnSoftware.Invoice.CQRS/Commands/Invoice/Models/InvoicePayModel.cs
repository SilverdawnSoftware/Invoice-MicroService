// ALLOWOVERWRITE-C27A372019CBB9707CDA0F6A9529DD1D

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models
{
	[DataContract]
    public partial class InvoicePay : CQRSBase, IInvoicePay
    { 
        [DataMember]	
        public int InvoiceId  { get; set; }
		  	
        [DataMember]	
        public double PaidAmount  { get; set; }
		  	
        [DataMember]	
        public double PaidTax  { get; set; }
		  	
    	 public InvoicePay()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoicePay";
        }	
	}
}

