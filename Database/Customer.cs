// ALLOWOVERWRITE-B55D6EBFD816369FCDE7950FA118906A-772D03F921E31E466114E8FE042924B4

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SilverdawnSoftware.Invoice.Database
{
	
    public class Customer 
    {

        /// <summary>  </summary>
        [Key]			
        public int CustomerId { get; set; }     	

        /// <summary>  </summary>
        public string Name { get; set; }     	

        /// <summary>  </summary>
        public string PhoneNumber { get; set; }     	

        /// <summary>  </summary>
        public string EmailAddress { get; set; }     	

        /// <summary>  </summary>
        public bool Active { get; set; }     	

        /// <summary>  </summary>
        public bool IsCompany { get; set; }     	

        /// <summary>  </summary>
        public string CustomerExteranlRef { get; set; }     	

        /// <summary>  </summary>
        public string TaxNo { get; set; }     	

        /// <summary>  </summary>	
        public virtual Address  Address   { get; set; }
    	/// <summary>
        /// Reference to  Entity
        /// </summary>	
    	public virtual Entity Entity { get; set; } 
    	/// <summary>
        /// List of Invoices
        /// </summary>	
    	public virtual List<Invoice> Invoices { get; set; }
    }
}

























