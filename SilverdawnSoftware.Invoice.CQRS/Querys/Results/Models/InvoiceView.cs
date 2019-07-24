// ALLOWOVERWRITE-D13EE6C26B2AB7FB32C4BFD38747A395

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models 
{
    public partial class InvoiceView : CQRSBase,IInvoiceView
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
        public decimal Tax  { get; set; }

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
        public IAddressView BillingAddress { get; set; } =new AddressView();						

        [DataMember]
        public IAddressView ShippingAddress { get; set; } =new AddressView();						

        [DataMember]
        public string TermsAndConditions   { get; set; }

        [DataMember]
        public string PaymentDetails  { get; set; }

        [DataMember]
        public int Status  { get; set; }

        [DataMember]
        public string Notes  { get; set; }
    	
    	 public InvoiceView()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Results.InvoiceView";
        }	
	}
}

