// ALLOWOVERWRITE-E8AFE337BE5D31D844430A538E026F44-03ABF70CE813CC0DEA999E5B15A2CB26

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.InvoiceLine.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.InvoiceLine.Models
{
	[DataContract]
    public partial class InvoiceLineAdd : CQRSBase, IInvoiceLineAdd
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
		  	
    	 public InvoiceLineAdd()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.InvoiceLine.Models.InvoiceLineAdd";
        }	
	}
}

