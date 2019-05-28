// ALLOWOVERWRITE-F6F225BACDDB11FF1FFA678A0FB07001

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models
{
    public partial interface IInvoiceCreate : ICQRSBase
    { 
         DateTime CreatedDate  { get; set; }
		  	
         DateTime DueDate  { get; set; }
		  	
         string OrderedBy  { get; set; }
		  	
         string PurchaseOrderRef  { get; set; }
		  	
         string EmailTo  { get; set; }
		  	
         string TermsAndConditions   { get; set; }
		  	
         string PaymentDetails  { get; set; }
		  	
         int CustomerId  { get; set; }
		  	
        /// To avoid Many to Many Relationships, use primary key https://github.com/aspnet/EntityFrameworkCore/issues/1368
        /// <summary>
        /// 
        /// </summary>	
        //public virtual Address BillngAddress <text> { get; set; }  				
         int BillngAddressAddressId  { get; set; }		
        /// To avoid Many to Many Relationships, use primary key https://github.com/aspnet/EntityFrameworkCore/issues/1368
        /// <summary>
        /// 
        /// </summary>	
        //public virtual Address ShippingAddress <text> { get; set; }  				
         int ShippingAddressAddressId  { get; set; }		
	}
}

