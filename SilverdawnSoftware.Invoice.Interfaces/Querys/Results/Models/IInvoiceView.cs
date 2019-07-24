// ALLOWOVERWRITE-CD98446070A7A8C57EB495F0CEA8A8F7

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
        int Status  { get; set; }	
        string Notes  { get; set; }	
	}
}



