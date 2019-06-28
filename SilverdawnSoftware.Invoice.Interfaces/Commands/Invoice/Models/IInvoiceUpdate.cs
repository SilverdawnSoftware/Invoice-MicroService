// ALLOWOVERWRITE-48EEEA13887B849D197B1A0B4009FBD5-FA742C7F50ABE917C904875D82596969

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
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

         decimal TaxTotal  { get; set; } 	

         string OrderedBy  { get; set; } 	

         string PurchaseOrderRef  { get; set; } 	

         int InvoiceNo  { get; set; } 	

         double PaidAmount  { get; set; } 	

         double PaidTax  { get; set; } 	

         bool InvoiceEmailed  { get; set; } 	

         string EmailTo  { get; set; } 	

         IAddressView  BillngAddress   { get; set; }

         IAddressView  ShippingAddress   { get; set; }

         string TermsAndConditions   { get; set; } 	

         string PaymentDetails  { get; set; } 	
	}
}


