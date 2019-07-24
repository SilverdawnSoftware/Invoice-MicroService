// ALLOWOVERWRITE-91793EA75DCB12E3E0E93E4304493143

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models
{
	[DataContract]
    public partial class InvoiceAdd : CQRSBase, IInvoiceAdd
    { 
        /// <summary> This is the date the invoice was created </summary>				
        [DataMember]	
        public DateTime CreatedDate  { get; set; }
		  	
        /// <summary> This is the date the invoice is due to paid </summary>				
        [DataMember]	
        public DateTime DueDate  { get; set; }
		  	
        /// <summary> The person who placed this order </summary>				
        [DataMember]	
        public string OrderedBy  { get; set; }
		  	
        /// <summary> Customer Purchase Order Reference for the Invoice </summary>				
        [DataMember]	
        public string PurchaseOrderRef  { get; set; }
		  	
        /// <summary> Who the invoice is to be emailed to. </summary>				
        [DataMember]	
        public string EmailTo  { get; set; }
		  	
        /// <summary> Any terms and conditions for the invoices. These can be added to the bottom of the invoice </summary>				
        [DataMember]	
        public string TermsAndConditions   { get; set; }
		  	
        /// <summary> What terms the invocie should be paid againist. e.g. Full payment in 30 days, </summary>				
        [DataMember]	
        public string PaymentDetails  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public int CustomerId  { get; set; }
		  	
        /// <summary> The address when the invoice is to be billed to. </summary>				
        [DataMember]	
        public IAddressView BillingAddress { get; set; }						
        /// <summary> The locaiton when the invoice goods are to be shipped to. </summary>				
        [DataMember]	
        public IAddressView ShippingAddress { get; set; }						
    	 public InvoiceAdd()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceAdd";
        }	
	}
}

