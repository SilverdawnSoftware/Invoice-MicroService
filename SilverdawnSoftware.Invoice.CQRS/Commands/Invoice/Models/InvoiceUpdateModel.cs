// ALLOWOVERWRITE-5E42F57BB5E477D7ED42D8A697B2FECB

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models
{
	[DataContract]
    public partial class InvoiceUpdate : CQRSBase, IInvoiceUpdate
    { 
        /// <summary> Primary Key for Invoices </summary>				
        [DataMember]	
        public int InvoiceId  { get; set; }
		  	
        /// <summary> This is the date the invoice was created </summary>				
        [DataMember]	
        public DateTime CreatedDate  { get; set; }
		  	
        /// <summary> This is the date the invoice is due to paid </summary>				
        [DataMember]	
        public DateTime DueDate  { get; set; }
		  	
        /// <summary> This is the date the invoice was fully paid off </summary>				
        [DataMember]	
        public DateTime PaidDate  { get; set; }
		  	
        /// <summary> This is the total of all the invoice lines + tax  </summary>				
        [DataMember]	
        public decimal GrandTotal  { get; set; }
		  	
        /// <summary> This is the total of all the invoice lines less tax </summary>				
        [DataMember]	
        public decimal SubTotal  { get; set; }
		  	
        /// <summary> This is the total of the tax for invoice line </summary>				
        [DataMember]	
        public decimal TaxTotal  { get; set; }
		  	
        /// <summary> The person who placed this order </summary>				
        [DataMember]	
        public string OrderedBy  { get; set; }
		  	
        /// <summary> Customer Purchase Order Reference for the Invoice </summary>				
        [DataMember]	
        public string PurchaseOrderRef  { get; set; }
		  	
        /// <summary> The Invoice No. This number is auto-incremented from the counters table.  </summary>				
        [DataMember]	
        public int InvoiceNo  { get; set; }
		  	
        /// <summary> How much of the invoice that has been paid </summary>				
        [DataMember]	
        public double PaidAmount  { get; set; }
		  	
        /// <summary> How much of the invoice tax that has been paid. </summary>				
        [DataMember]	
        public double PaidTax  { get; set; }
		  	
        /// <summary> Flag to indicate if the invoice has been emailed to the client </summary>				
        [DataMember]	
        public bool InvoiceEmailed  { get; set; }
		  	
        /// <summary> Who the invoice is to be emailed to. </summary>				
        [DataMember]	
        public string EmailTo  { get; set; }
		  	
        /// <summary> The address when the invoice is to be billed to. </summary>				
        [DataMember]	
        public IAddressView BillngAddress { get; set; }						
        /// <summary> The locaiton when the invoice goods are to be shipped to. </summary>				
        [DataMember]	
        public IAddressView ShippingAddress { get; set; }						
        /// <summary> Any terms and conditions for the invoices. These can be added to the bottom of the invoice </summary>				
        [DataMember]	
        public string TermsAndConditions   { get; set; }
		  	
        /// <summary> What terms the invocie should be paid againist. e.g. Full payment in 30 days, </summary>				
        [DataMember]	
        public string PaymentDetails  { get; set; }
		  	
    	 public InvoiceUpdate()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceUpdate";
        }	
	}
}

