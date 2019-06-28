// ALLOWOVERWRITE-9A05688D0CCECEC6676009B5E11B6D9C-BF6DFD324EF493DB3AC0BF0ED8294894

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models
{
    public partial interface IInvoiceAdd : ICQRSBase
    { 

         DateTime CreatedDate  { get; set; } 	

         DateTime DueDate  { get; set; } 	

         string OrderedBy  { get; set; } 	

         string PurchaseOrderRef  { get; set; } 	

         string EmailTo  { get; set; } 	

         string TermsAndConditions   { get; set; } 	

         string PaymentDetails  { get; set; } 	

         int CustomerId  { get; set; } 	

         IAddressView  BillingAddress   { get; set; }

         IAddressView  ShippingAddress   { get; set; }
	}
}


