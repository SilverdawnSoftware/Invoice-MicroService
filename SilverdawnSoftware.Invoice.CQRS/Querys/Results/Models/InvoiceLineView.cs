// ALLOWOVERWRITE-AA053B0BB959CDBD0BCB7A0296B9AE6E

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models 
{
    public partial class InvoiceLineView : CQRSBase,IInvoiceLineView
    { 
        [DataMember]
        public int InvoiceLineId  { get; set; }
		  	
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
		  	
    	 public InvoiceLineView()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Results.InvoiceLineView";
        }	
	}
}

