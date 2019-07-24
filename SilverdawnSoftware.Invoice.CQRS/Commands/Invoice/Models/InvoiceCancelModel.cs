// ALLOWOVERWRITE-94BD889669012018E72ADC855B0003CB

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models
{
	[DataContract]
    public partial class InvoiceCancel : CQRSBase, IInvoiceCancel
    { 
        /// <summary> Primary Key for Invoices </summary>				
        [DataMember]	
        public int InvoiceId  { get; set; }
		  	
        /// <summary> Any extra information to be applied to the invoice. </summary>				
        [DataMember]	
        public string Reason  { get; set; }
		  	
    	 public InvoiceCancel()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceCancel";
        }	
	}
}

