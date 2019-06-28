// ALLOWOVERWRITE-142D8D949800BD19148C935A9DC289AD-1E191171693C823C57C3991DE7051138

using System;
using System.Collections.Generic;
using System.Linq;

namespace SilverdawnSoftware.Invoice.Database.Transactions.Model
{
    public class CustomerAdd
    {
	    	
        /// <summary>
        /// 
        /// </summary>	    		
        public bool Active  { get; set; } 
	    	
        public Address  Address   { get; set; }
	    	
        /// <summary>
        /// 
        /// </summary>	    		
        public string CustomerExteranlRef  { get; set; } 
	    	
        /// <summary>
        /// 
        /// </summary>	    		
        public int CustomerId  { get; set; } 
	    	
        /// <summary>
        /// 
        /// </summary>	    		
        public string EmailAddress  { get; set; } 
	    	
        /// <summary>
        /// 
        /// </summary>	    		
        public bool IsCompany  { get; set; } 
	    	
        /// <summary>
        /// 
        /// </summary>	    		
        public string Name  { get; set; } 
	    	
        /// <summary>
        /// 
        /// </summary>	    		
        public string PhoneNumber  { get; set; } 
	    	
        /// <summary>
        /// 
        /// </summary>	    		
        public string TaxNo  { get; set; } 
        /// <summary>
        /// 
        /// </summary>	       
        public int EntityEntityId { get; set; } 
    }    	    	
}




