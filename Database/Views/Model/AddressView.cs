// ALLOWOVERWRITE-0FF841A9FF704C46C19D02E67A4AA58C-37DD83F5C01BBC2B5B62E6EC3DACA38F

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
    	    	
    	
    	
	    	public static explicit operator AddressView(Address item)
	    	{
	    		var result=new AddressView();
	    	 
		    	result.AddresLine2 = item.AddresLine2;     
		    	result.AddressExternalRef = item.AddressExternalRef;     
		    	result.AddressLine1 = item.AddressLine1;     
		    	result.AddressLine3 = item.AddressLine3;     
		    	result.City = item.City;     
		    	result.Country = item.Country;     
		    	result.PostZipCode = item.PostZipCode;     
		    	result.StateCounty = item.StateCounty;     
	    	
	    	
    	
    			return result;
    	}   
   
    }
}



