// ALLOWOVERWRITE-2D15320A38C6276FF60168F4169BD28D

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models
{
	[DataContract]
    public partial class InvoiceEmail : CQRSBase, IInvoiceEmail
    { 
        /// <summary> Primary Key for Invoices </summary>				
        [DataMember]	
        public int InvoiceId  { get; set; }
		  	
    	 public InvoiceEmail()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceEmail";
        }	
	}
}

