// ALLOWOVERWRITE-19A17215E2922A2F684AA7A9EE382805

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;



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
        public string EmalAddress { get; set; }     	
        /// <summary>  </summary>
        public bool Active { get; set; }     	
        /// <summary>  </summary>
        public bool IsCompany { get; set; }     	
        /// <summary>  </summary>
        public string CustomerExteranlRef { get; set; }     	
        /// <summary>  </summary>
        public string TaxNo { get; set; }     	
    	
    	/// <summary>
        /// Reference to  Entity
        /// </summary>	
    	public virtual Entity Entity { get; set; } 
    	
    	/// <summary>
        /// List of Addresss
        /// </summary>	
    	public virtual List<Address> Addresss { get; set; }
    	/// <summary>
        /// List of Invoices
        /// </summary>	
    	public virtual List<Invoice> Invoices { get; set; }
    	
    	
    	
    	
    }
    
    
}


























