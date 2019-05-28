// ALLOWOVERWRITE-E3DD4BCA3B9C4119055F7341D6F18585

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database
{
    public class Entity 
    {
        /// <summary>  </summary>
        [Key]			
        public int EntityId { get; set; }     	
        /// <summary>  </summary>
        public string Name { get; set; }     	
        /// <summary>  </summary>
        public string EntityExternalRef { get; set; }     	
        /// To avoid Many to Many Relationships, use primary key https://github.com/aspnet/EntityFrameworkCore/issues/1368
        /// <summary>
        /// 
        /// </summary>	
        //public virtual Address Address <text> { get; set; }  				
        public int AddressAddressId  { get; set; }		
        /// <summary>  </summary>
        public string LogoURL { get; set; }     	
    	
    	
    	/// <summary>
        /// List of Customers
        /// </summary>	
    	public virtual List<Customer> Customers { get; set; }
    	
    	
    	
    	
    }
    
    
}


























