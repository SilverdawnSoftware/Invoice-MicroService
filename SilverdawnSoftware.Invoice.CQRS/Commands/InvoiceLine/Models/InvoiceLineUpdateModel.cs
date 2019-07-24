// ALLOWOVERWRITE-3C54EF59ECF4D15DB6F3E25E2F0334CD

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
        /// <summary>  </summary>				
        [DataMember]	
        public int InvoiceLineId  { get; set; }
		  	
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
		  	
    	 public InvoiceLineUpdate()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.InvoiceLine.Models.InvoiceLineUpdate";
        }	
	}
}

