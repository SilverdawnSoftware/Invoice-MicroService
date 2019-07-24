// ALLOWOVERWRITE-42E2D459C4CF2C9DFE5C2C9A905C2B85

using System;
using System.Collections.Generic;
using System.Linq;

namespace SilverdawnSoftware.Invoice.Database.Transactions.Model
{
    public class CustomerUpdate
    {
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public bool Active  { get; set; } 
				/// <summary>
                /// 
                /// </summary>	  
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
    	}
}



