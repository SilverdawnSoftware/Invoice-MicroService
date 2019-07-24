// ALLOWOVERWRITE-26325DB7094DE3B004C43A33DA194740

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models
{
    public partial class InvoiceChangeStatus : CQRSBase, IInvoiceChangeStatus
    { 
        /// <summary> Primary Key for Invoices </summary>				
        [DataMember]	
        public int InvoiceId  { get; set; }
		  	
        /// <summary> The status of the invoices.  </summary>				
        [DataMember]	
        public int Status  { get; set; }
		  	
    	 public InvoiceChangeStatus()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceChangeStatus";
        }	
	}
}

