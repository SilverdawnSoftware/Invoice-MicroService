// ALLOWOVERWRITE-2B3D3604430134CD0C39A91661217946

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models
{
	[DataContract]
    public partial class InvoiceUpdateNotes : CQRSBase, IInvoiceUpdateNotes
    { 
        /// <summary> Primary Key for Invoices </summary>				
        [DataMember]	
        public int InvoiceId  { get; set; }
		  	
        /// <summary> Any extra information to be applied to the invoice. </summary>				
        [DataMember]	
        public string Notes  { get; set; }
		  	
    	 public InvoiceUpdateNotes()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceUpdateNotes";
        }	
	}
}

