// ALLOWOVERWRITE-9534AD80223EBFEA218F6B80E7AEC3FF

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database
{
    public class Address 
    {
        /// <summary>  </summary>
        [Key]			
        public int AddressId { get; set; }     	
        /// <summary>  </summary>
        public string AddressLine1 { get; set; }     	
        /// <summary>  </summary>
        public string AddresLine2 { get; set; }     	
        /// <summary>  </summary>
        public string City { get; set; }     	
        /// <summary>  </summary>
        public string PostZipCode { get; set; }     	
        /// <summary>  </summary>
        public string StateCounty { get; set; }     	
        /// <summary>  </summary>
        public string Country { get; set; }     	
        /// <summary>  </summary>
        public string AddressExternalRef { get; set; }     	
        /// <summary>  </summary>
        public string AddressLine3 { get; set; }     	
    	
    	/// <summary>
        /// Reference to  Customer
        /// </summary>	
    	public virtual Customer Customer { get; set; } 
    	
    	
    	
    	
    	
    }
    
    
}


























