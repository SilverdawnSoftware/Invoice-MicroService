// ALLOWOVERWRITE-DD7DCFF74CE6C27FF674670AD8B02221

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models
{
    public partial class InvoiceUpdateTotals : CQRSBase, IInvoiceUpdateTotals
    { 
        /// <summary> Primary Key for Invoices </summary>				
        [DataMember]	
        public int InvoiceId  { get; set; }
		  	
        /// <summary> This is the total of all the invoice lines less tax </summary>				
        [DataMember]	
        public decimal SubTotal  { get; set; }
		  	
        /// <summary> This is the total of the tax for invoice line </summary>				
        [DataMember]	
        public decimal TaxTotal  { get; set; }
		  	
        /// <summary> This is the total of all the invoice lines + tax  </summary>				
        [DataMember]	
        public decimal GrandTotal  { get; set; }
		  	
    	 public InvoiceUpdateTotals()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceUpdateTotals";
        }	
	}
}

