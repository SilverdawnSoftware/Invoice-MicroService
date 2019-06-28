// ALLOWOVERWRITE-59070C1A7940E821B4B168709A2521F2-54D1A2D59B4DC3EF76E268CB1CF8036C

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
		
         IAddressView  BillingAddress   { get; set; }					
		
         IAddressView  ShippingAddress   { get; set; }					
		
        string TermsAndConditions   { get; set; }	
		
        string PaymentDetails  { get; set; }	
	}
}



