// ALLOWOVERWRITE-0A92543E988599C72BEE6BD7D349232E-31AA2C8F0558DE19D19FBA3FA034B8B2

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

        /// <summary>  </summary>
        public DateTime CreatedDate { get; set; }     	

        /// <summary>  </summary>
        public DateTime DueDate { get; set; }     	

        /// <summary>  </summary>
        public DateTime PaidDate { get; set; }     	

        /// <summary>  </summary>
        public decimal GrandTotal { get; set; }     	

        /// <summary>  </summary>
        public decimal SubTotal { get; set; }     	

        /// <summary>  </summary>
        public decimal TaxTotal { get; set; }     	

        /// <summary>  </summary>
        public string OrderedBy { get; set; }     	

        /// <summary>  </summary>
        public string PurchaseOrderRef { get; set; }     	

        /// <summary>  </summary>
        public int InvoiceNo { get; set; }     	

        /// <summary>  </summary>
        public double PaidAmount { get; set; }     	

        /// <summary>  </summary>
        public double PaidTax { get; set; }     	

        /// <summary>  </summary>
        public bool InvoiceEmailed { get; set; }     	

        /// <summary>  </summary>
        public string EmailTo { get; set; }     	

        /// <summary>  </summary>	
        public virtual Address  BillingAddress   { get; set; }

        /// <summary>  </summary>	
        public virtual Address  ShippingAddress   { get; set; }

        /// <summary>  </summary>
        public string TermsAndConditions  { get; set; }     	

        /// <summary>  </summary>
        public string PaymentDetails { get; set; }     	

        /// <summary>  </summary>	
        public InvoiceStatus Status { get; set; }  

        /// <summary>  </summary>
        public string Notes { get; set; }     	
    	/// <summary>
        /// Reference to  Customer
        /// </summary>	
    	public virtual Customer Customer { get; set; } 
    	/// <summary>
        /// List of InvoiceLines
        /// </summary>	
    	public virtual List<InvoiceLine> InvoiceLines { get; set; }
    }
}

























