// ALLOWOVERWRITE-48EF3DBCD775936152C2A5F2E44CB941

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SilverdawnSoftware.Invoice.Database
{
	
    public class PaymentHistory 
    {

        /// <summary>  </summary>
        [Key]			
        public int PaymentHistoryId { get; set; }     	

        /// <summary>  </summary>
        public DateTime PaymentDate { get; set; }     	

        /// <summary>  </summary>
        public decimal Amount { get; set; }     	

        /// <summary>  </summary>
        public string Reference { get; set; }     	
    	/// <summary>
        /// Reference to  Invoice
        /// </summary>	
    	public virtual Invoice Invoice { get; set; } 
    }
}

























