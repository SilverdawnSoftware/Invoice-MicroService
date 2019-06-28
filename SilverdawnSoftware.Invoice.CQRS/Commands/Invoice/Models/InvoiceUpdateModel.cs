// ALLOWOVERWRITE-C7A8F96F7C5A720B287FB66B4E74857C-EB4441DCD49D8BE8B1AADE884ED6D6F3

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
        [DataMember]	
        public int InvoiceId  { get; set; }
		  	
        [DataMember]	
        public DateTime CreatedDate  { get; set; }
		  	
        [DataMember]	
        public DateTime DueDate  { get; set; }
		  	
        [DataMember]	
        public DateTime PaidDate  { get; set; }
		  	
        [DataMember]	
        public decimal GrandTotal  { get; set; }
		  	
        [DataMember]	
        public decimal SubTotal  { get; set; }
		  	
        [DataMember]	
        public decimal TaxTotal  { get; set; }
		  	
        [DataMember]	
        public string OrderedBy  { get; set; }
		  	
        [DataMember]	
        public string PurchaseOrderRef  { get; set; }
		  	
        [DataMember]	
        public int InvoiceNo  { get; set; }
		  	
        [DataMember]	
        public double PaidAmount  { get; set; }
		  	
        [DataMember]	
        public double PaidTax  { get; set; }
		  	
        [DataMember]	
        public bool InvoiceEmailed  { get; set; }
		  	
        [DataMember]	
        public string EmailTo  { get; set; }
		  	
        [DataMember]	
        public IAddressView BillngAddress { get; set; }						
        [DataMember]	
        public IAddressView ShippingAddress { get; set; }						
        [DataMember]	
        public string TermsAndConditions   { get; set; }
		  	
        [DataMember]	
        public string PaymentDetails  { get; set; }
		  	
    	 public InvoiceUpdate()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceUpdate";
        }	
	}
}

