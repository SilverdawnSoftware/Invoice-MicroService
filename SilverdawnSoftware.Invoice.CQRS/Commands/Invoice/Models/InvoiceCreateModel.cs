// ALLOWOVERWRITE-AFF7B90C7095C412C1259FE2DFEF8D38

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models
{
	[DataContract]
    public partial class InvoiceCreate : CQRSBase, IInvoiceCreate
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
        /// To avoid Many to Many Relationships, use primary key https://github.com/aspnet/EntityFrameworkCore/issues/1368
        /// <summary>
        /// 
        /// </summary>	
        //public virtual Address BillngAddress <text> { get; set; }  				
          public int BillngAddressAddressId  { get; set; }		
        [DataMember]	
        /// To avoid Many to Many Relationships, use primary key https://github.com/aspnet/EntityFrameworkCore/issues/1368
        /// <summary>
        /// 
        /// </summary>	
        //public virtual Address ShippingAddress <text> { get; set; }  				
          public int ShippingAddressAddressId  { get; set; }		
    	 public InvoiceCreate()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceCreate";
        }	
	}
}

