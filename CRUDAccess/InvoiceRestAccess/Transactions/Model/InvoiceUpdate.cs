// ALLOWOVERWRITE-A674EE1B884850533E71E4D5ECA67AB1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Database.Transactions.Model
{
	[DataContract]
    public class InvoiceUpdate
    {
              /// <summary>
              /// The address when the invoice is to be billed to. 
              /// </summary>
              //[DataMember(Name = "billingAddress")]                 
             // public Address Address { get; set; } 	
              /// <summary>
              /// This is the date the invoice was created 
              /// </summary>
              [DataMember(Name = "createdDate")]                 
              public DateTime CreatedDate { get; set; } 
              /// <summary>
              /// This is the date the invoice is due to paid 
              /// </summary>
              [DataMember(Name = "dueDate")]                 
              public DateTime DueDate { get; set; } 
              /// <summary>
              /// Who the invoice is to be emailed to. 
              /// </summary>
              [DataMember(Name = "emailTo")]                 
              public string EmailTo { get; set; } 
              /// <summary>
              /// This is the total of all the invoice lines + tax  
              /// </summary>
              [DataMember(Name = "grandTotal")]                 
              public decimal GrandTotal { get; set; } 
              /// <summary>
              /// Flag to indicate if the invoice has been emailed to the client 
              /// </summary>
              [DataMember(Name = "invoiceEmailed")]                 
              public bool InvoiceEmailed { get; set; } 
              /// <summary>
              /// Primary Key for Invoices 
              /// </summary>
              [DataMember(Name = "invoiceId")]                 
              public int InvoiceId { get; set; } 
              /// <summary>
              /// The Invoice No. This number is auto-incremented from the counters table.  
              /// </summary>
              [DataMember(Name = "invoiceNo")]                 
              public int InvoiceNo { get; set; } 
              /// <summary>
              /// Any extra information to be applied to the invoice. 
              /// </summary>
              [DataMember(Name = "notes")]                 
              public string Notes { get; set; } 
              /// <summary>
              /// The person who placed this order 
              /// </summary>
              [DataMember(Name = "orderedBy")]                 
              public string OrderedBy { get; set; } 
              /// <summary>
              /// How much of the invoice that has been paid 
              /// </summary>
              [DataMember(Name = "paidAmount")]                 
              public double PaidAmount { get; set; } 
              /// <summary>
              /// This is the date the invoice was fully paid off 
              /// </summary>
              [DataMember(Name = "paidDate")]                 
              public DateTime PaidDate { get; set; } 
              /// <summary>
              /// How much of the invoice tax that has been paid. 
              /// </summary>
              [DataMember(Name = "paidTax")]                 
              public double PaidTax { get; set; } 
              /// <summary>
              /// What terms the invocie should be paid againist. e.g. Full payment in 30 days, 
              /// </summary>
              [DataMember(Name = "paymentDetails")]                 
              public string PaymentDetails { get; set; } 
              /// <summary>
              /// Customer Purchase Order Reference for the Invoice 
              /// </summary>
              [DataMember(Name = "purchaseOrderRef")]                 
              public string PurchaseOrderRef { get; set; } 
              /// <summary>
              /// The locaiton when the invoice goods are to be shipped to. 
              /// </summary>
              //[DataMember(Name = "shippingAddress")]                 
             // public Address Address { get; set; } 	
              /// <summary>
              /// The status of the invoices. 
              /// </summary>
              [DataMember(Name = "status")]                 
              public int Status { get; set; } 				
              /// <summary>
              /// This is the total of all the invoice lines less tax 
              /// </summary>
              [DataMember(Name = "subTotal")]                 
              public decimal SubTotal { get; set; } 
              /// <summary>
              /// This is the total of the tax for invoice line 
              /// </summary>
              [DataMember(Name = "taxTotal")]                 
              public decimal TaxTotal { get; set; } 
              /// <summary>
              /// Any terms and conditions for the invoices. These can be added to the bottom of the invoice 
              /// </summary>
              [DataMember(Name = "termsAndConditions ")]                 
              public string TermsAndConditions  { get; set; } 
    }
}


