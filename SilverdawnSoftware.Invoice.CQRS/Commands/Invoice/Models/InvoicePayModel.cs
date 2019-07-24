// ALLOWOVERWRITE-FC31A2AC551931DB853209F5A0404F5B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models
{
	[DataContract]
    public partial class InvoicePay : CQRSBase, IInvoicePay
    { 
        /// <summary> Primary Key for Invoices </summary>				
        [DataMember]	
        public int InvoiceId  { get; set; }
		  	
        /// <summary> How much of the invoice that has been paid </summary>				
        [DataMember]	
        public double PaidAmount  { get; set; }
		  	
        /// <summary> How much of the invoice tax that has been paid. </summary>				
        [DataMember]	
        public double PaidTax  { get; set; }
		  	
    	 public InvoicePay()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoicePay";
        }	
	}
}

