// ALLOWOVERWRITE-9134DF299362A8EB7986003C4C117EED

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database
{
    public class Entity 
    {
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public int EntityId  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string Name  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string EntityExternalRef  { get; set; }     	
				
				/// To avoid Many to Many Relationships, use primary key https://github.com/aspnet/EntityFrameworkCore/issues/1368
				/// <summary>
                /// 
                /// </summary>	
				//public virtual Address Address  { get; set; }  
				public int AddressAddressId  { get; set; } 		
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string LogoURL  { get; set; }     	
    	
    	
    	
    	
    	/// <summary>
        /// List of Customers
        /// </summary>	
    	public virtual List<Customer> Customers { get; set; } 
    	
    	
    	
    	
    }
    
    
}

























