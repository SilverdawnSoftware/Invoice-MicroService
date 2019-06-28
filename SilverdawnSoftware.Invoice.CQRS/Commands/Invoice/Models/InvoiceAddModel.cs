// ALLOWOVERWRITE-E660CC58AE91AC17FAE8F247DCC4FFA9-679FF52FF028900EC1F5584A7EF5F9BD

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
        [DataMember]	
        public DateTime CreatedDate  { get; set; }
		  	
        [DataMember]	
        public DateTime DueDate  { get; set; }
		  	
        [DataMember]	
        public string OrderedBy  { get; set; }
		  	
        [DataMember]	
        public string PurchaseOrderRef  { get; set; }
		  	
        [DataMember]	
        public string EmailTo  { get; set; }
		  	
        [DataMember]	
        public string TermsAndConditions   { get; set; }
		  	
        [DataMember]	
        public string PaymentDetails  { get; set; }
		  	
        [DataMember]	
        public int CustomerId  { get; set; }
		  	
        [DataMember]	
        public IAddressView BillingAddress { get; set; }						
        [DataMember]	
        public IAddressView ShippingAddress { get; set; }						
    	 public InvoiceAdd()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceAdd";
        }	
	}
}

