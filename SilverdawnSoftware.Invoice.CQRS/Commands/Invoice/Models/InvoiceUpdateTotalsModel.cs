// ALLOWOVERWRITE-926EAD2A79A63E0C9DFF0F7080727CE5-69C7EE46F3817C3AEA864BC45876ECFE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models
{
    public partial class InvoiceUpdateTotals : CQRSBase, IInvoiceUpdateTotals
    { 
        [DataMember]	
        public int InvoiceId  { get; set; }
		  	
        [DataMember]	
        public decimal SubTotal  { get; set; }
		  	
        [DataMember]	
        public decimal TaxTotal  { get; set; }
		  	
        [DataMember]	
        public decimal GrandTotal  { get; set; }
		  	
    	 public InvoiceUpdateTotals()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceUpdateTotals";
        }	
	}
}

