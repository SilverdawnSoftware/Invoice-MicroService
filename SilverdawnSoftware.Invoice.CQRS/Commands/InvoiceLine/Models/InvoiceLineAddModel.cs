// ALLOWOVERWRITE-1A4917092FB74F21329E4717009B0765

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
        /// <summary>  </summary>				
        [DataMember]	
        public double Quantity  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public decimal UnitCost  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public decimal SubTotal  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public decimal TaxTotal  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public decimal LineTotal  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public string Product  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public bool TaxExempt  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public string ProductCode  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public string Notes  { get; set; }
		  	
        /// <summary> Primary Key for Invoices </summary>				
        [DataMember]	
        public int InvoiceId  { get; set; }
		  	
    	 public InvoiceLineAdd()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.InvoiceLine.Models.InvoiceLineAdd";
        }	
	}
}

