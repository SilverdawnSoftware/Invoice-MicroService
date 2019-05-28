// ALLOWOVERWRITE-618F655416BB1C5BB5C5720557C36795

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models
{
    public partial interface IInvoiceUpdate : ICQRSBase
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
		  	
         int BillngAddress  { get; set; }
		  	
         int ShippingAddress  { get; set; }
		  	
         string TermsAndConditions   { get; set; }
		  	
         string PaymentDetails  { get; set; }
		  	
	}
}

