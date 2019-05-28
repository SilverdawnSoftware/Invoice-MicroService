// ALLOWOVERWRITE-54BEB06C3B7434BBA795472F0823F01C

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models 
{
    public partial interface IInvoiceView : ICQRSBase
    { 
         int InvoiceId  { get; set; }
		  	
         DateTime CreatedDate  { get; set; }
		  	
         DateTime DueDate  { get; set; }
		  	
         DateTime PaidDate  { get; set; }
		  	
         decimal GrandTotal  { get; set; }
		  	
         decimal SubTotal  { get; set; }
		  	
         decimal Tax  { get; set; }
		  	
         string OrderedBy  { get; set; }
		  	
         string PurchaseOrderRef  { get; set; }
		  	
         int InvoiceNo  { get; set; }
		  	
         double PaidAmount  { get; set; }
		  	
         double PaidTax  { get; set; }
		  	
         bool InvoiceEmailed  { get; set; }
		  	
         string EmailTo  { get; set; }
		  	
        /// To avoid Many to Many Relationships, use primary key https://github.com/aspnet/EntityFrameworkCore/issues/1368
        /// <summary>
        /// 
        /// </summary>	
        //public virtual AddressView BillngAddress <text> { get; set; }  				
         int BillngAddressAddressId  { get; set; }		
        /// To avoid Many to Many Relationships, use primary key https://github.com/aspnet/EntityFrameworkCore/issues/1368
        /// <summary>
        /// 
        /// </summary>	
        //public virtual AddressView ShippingAddress <text> { get; set; }  				
         int ShippingAddressAddressId  { get; set; }		
         string TermsAndConditions   { get; set; }
		  	
         string PaymentDetails  { get; set; }
		  	
	}
}



