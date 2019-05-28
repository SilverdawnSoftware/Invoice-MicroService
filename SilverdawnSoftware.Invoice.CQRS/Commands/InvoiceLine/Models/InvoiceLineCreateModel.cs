// ALLOWOVERWRITE-099DA87F152F92BF3E01D33EAADA7ADC

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.InvoiceLine.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.InvoiceLine.Models
{
	[DataContract]
    public partial class InvoiceLineCreate : CQRSBase, IInvoiceLineCreate
    { 
        [DataMember]	
        public double Quantity  { get; set; }
		  	
        [DataMember]	
        public decimal UnitCost  { get; set; }
		  	
        [DataMember]	
        public decimal SubTotal  { get; set; }
		  	
        [DataMember]	
        public decimal TaxTotal  { get; set; }
		  	
        [DataMember]	
        public decimal LineTotal  { get; set; }
		  	
        [DataMember]	
        public string Product  { get; set; }
		  	
        [DataMember]	
        public bool TaxExempt  { get; set; }
		  	
        [DataMember]	
        public string ProductCode  { get; set; }
		  	
        [DataMember]	
        public string Notes  { get; set; }
		  	
        [DataMember]	
        public int InvoiceId  { get; set; }
		  	
    	 public InvoiceLineCreate()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.InvoiceLine.Models.InvoiceLineCreate";
        }	
	}
}

