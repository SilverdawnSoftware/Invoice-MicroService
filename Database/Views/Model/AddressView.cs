// ALLOWOVERWRITE-16BC6A83C9662771647481F3DE076476

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database.Views.Model
{

    public class AddressView
    {
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  AddresLine2  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  AddressExternalRef  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public int  AddressId  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  AddressLine1  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  AddressLine3  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  City  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  Country  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  PostZipCode  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  StateCounty  { get; set; } 	    	
    						  
			/// <summary>
	        /// Reference of PrimaryKey for Customer
	        /// </summary>
			public  int CustomerCustomerId { get; set; }   
					  
					  /// <summary>
                      /// Reference to  Customer Name Property
                      /// </summary>	
					  public string CustomerName { get; set; }   
    	
    	
    	
	    	public static explicit operator AddressView(Address item)
	    	{
	    		var result=new AddressView();
	    	 
		    	result.AddresLine2 = item.AddresLine2;     
		    	result.AddressExternalRef = item.AddressExternalRef;     
		    	result.AddressId = item.AddressId;     
		    	result.AddressLine1 = item.AddressLine1;     
		    	result.AddressLine3 = item.AddressLine3;     
		    	result.City = item.City;     
		    	result.Country = item.Country;     
		    	result.PostZipCode = item.PostZipCode;     
		    	result.StateCounty = item.StateCounty;     
	    	
				if (item.Customer != null) 
				{   
			    	result.CustomerCustomerId=item.Customer.CustomerId;
			    } 
			    		if (item.Customer != null) 
				    			{   	
			    			result.CustomerName=item.Customer.Name.ToString(); 
			    			} 
	    	
    	
    			return result;
    	}   
   
    }
}



