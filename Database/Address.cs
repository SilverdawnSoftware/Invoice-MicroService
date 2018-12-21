// ALLOWOVERWRITE-94EE3D4B106D253065A61924BBBD87F1

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database
{
    public class Address 
    {
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public int AddressId  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string AddressLine1  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string AddresLine2  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string City  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string PostZipCode  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string StateCounty  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string Country  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string AddressExternalRef  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string AddressLine3  { get; set; }     	
    	
    	
    	
    	/// <summary>
        /// Reference to  Customer
        /// </summary>	
    	public virtual Customer Customer { get; set; } 
    	
    	
    	
    	
    	
    }
    
    
}

























