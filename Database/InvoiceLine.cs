// ALLOWOVERWRITE-BAF44954676C0825FC20B6FAF1B3CC72-82F5C85D5584A240E03E40C26F9CBD1E

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SilverdawnSoftware.Invoice.Database
{
	
    public class InvoiceLine 
    {

        /// <summary>  </summary>
        [Key]			
        public int InvoiceLineId { get; set; }     	

        /// <summary>  </summary>
        public double Quantity { get; set; }     	

        /// <summary>  </summary>
        public decimal UnitCost { get; set; }     	

        /// <summary>  </summary>
        public decimal SubTotal { get; set; }     	

        /// <summary>  </summary>
        public decimal TaxTotal { get; set; }     	

        /// <summary>  </summary>
        public decimal LineTotal { get; set; }     	

        /// <summary>  </summary>
        public string Product { get; set; }     	

        /// <summary>  </summary>
        public bool TaxExempt { get; set; }     	

        /// <summary>  </summary>
        public string ProductCode { get; set; }     	

        /// <summary>  </summary>
        public string Notes { get; set; }     	
    	/// <summary>
        /// Reference to  Invoice
        /// </summary>	
    	public virtual Invoice Invoice { get; set; } 
    }
}

























