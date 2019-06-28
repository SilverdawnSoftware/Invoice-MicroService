// ALLOWOVERWRITE-F846D767C6DD50A600FE9736FFC5C288-39D493AE178937C7AD05DBF05F5F564C

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.InvoiceLine.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.InvoiceLine.Models
{
	[DataContract]
    public partial class InvoiceLineUpdate : CQRSBase, IInvoiceLineUpdate
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
		  	
    	 public InvoiceLineUpdate()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.InvoiceLine.Models.InvoiceLineUpdate";
        }	
	}
}

