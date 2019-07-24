// ALLOWOVERWRITE-B091EBDC19522DFA256AB21CF1DDAA2B

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SilverdawnSoftware.Invoice.Database
{
	
    public class Invoice 
    {

        /// <summary> Primary Key for Invoices </summary>
        [Key]			
        public int InvoiceId { get; set; }     	

        /// <summary> This is the date the invoice was created </summary>
        public DateTime CreatedDate { get; set; }     	

        /// <summary> This is the date the invoice is due to paid </summary>
        public DateTime DueDate { get; set; }     	

        /// <summary> This is the date the invoice was fully paid off </summary>
        public DateTime PaidDate { get; set; }     	

        /// <summary> This is the total of all the invoice lines + tax  </summary>
        public decimal GrandTotal { get; set; }     	

        /// <summary> This is the total of all the invoice lines less tax </summary>
        public decimal SubTotal { get; set; }     	

        /// <summary> This is the total of the tax for invoice line </summary>
        public decimal TaxTotal { get; set; }     	

        /// <summary> The person who placed this order </summary>
        public string OrderedBy { get; set; }     	

        /// <summary> Customer Purchase Order Reference for the Invoice </summary>
        public string PurchaseOrderRef { get; set; }     	

        /// <summary> The Invoice No. This number is auto-incremented from the counters table.  </summary>
        public int InvoiceNo { get; set; }     	

        /// <summary> How much of the invoice that has been paid </summary>
        public double PaidAmount { get; set; }     	

        /// <summary> How much of the invoice tax that has been paid. </summary>
        public double PaidTax { get; set; }     	

        /// <summary> Flag to indicate if the invoice has been emailed to the client </summary>
        public bool InvoiceEmailed { get; set; }     	

        /// <summary> Who the invoice is to be emailed to. </summary>
        public string EmailTo { get; set; }     	

        /// <summary> The address when the invoice is to be billed to. </summary>	
        public virtual Address  BillingAddress   { get; set; }

        /// <summary> The locaiton when the invoice goods are to be shipped to. </summary>	
        public virtual Address  ShippingAddress   { get; set; }

        /// <summary> Any terms and conditions for the invoices. These can be added to the bottom of the invoice </summary>
        public string TermsAndConditions  { get; set; }     	

        /// <summary> What terms the invocie should be paid againist. e.g. Full payment in 30 days, </summary>
        public string PaymentDetails { get; set; }     	

        /// <summary> The status of the invoices.  </summary>	
        public InvoiceStatus Status { get; set; }  

        /// <summary> Any extra information to be applied to the invoice. </summary>
        public string Notes { get; set; }     	
    	/// <summary>
        /// Reference to  Customer
        /// </summary>	
    	public virtual Customer Customer { get; set; } 
    	/// <summary>
        /// List of InvoiceLines
        /// </summary>	
    	public virtual List<InvoiceLine> InvoiceLines { get; set; }
    	/// <summary>
        /// List of PaymentHistorys
        /// </summary>	
    	public virtual List<PaymentHistory> PaymentHistorys { get; set; }
    }
}

























