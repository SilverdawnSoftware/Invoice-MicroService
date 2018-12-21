// ALLOWOVERWRITE-AB260E837569CE2613F76F4596828E03

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database.Views.Model
{

    public class EntityView
    {
			    		
    		/// <summary>
            ///  
            /// </summary>	
			    		
			public int AddressAddressId { get; set; }   
			    		
    		/// <summary>
            /// 
            /// </summary>	
			public string AddressPostZipCode { get; set; }   
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  EntityExternalRef  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public int  EntityId  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  LogoURL  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  Name  { get; set; } 	    	
    	    	
    	
    	
	    	public static explicit operator EntityView(Entity item)
	    	{
	    		var result=new EntityView();
	    	 
				//if (item.Address != null) 
				//{   	
				result.AddressAddressId= item.AddressAddressId;
				//result.AddressAddressId= item.Address.AddressId;
				//} 
				//if (item.Address != null) 
				//{   	
				//result.AddressPostZipCode= item.Address.PostZipCode;
				//} 
		    	result.EntityExternalRef = item.EntityExternalRef;     
		    	result.EntityId = item.EntityId;     
		    	result.LogoURL = item.LogoURL;     
		    	result.Name = item.Name;     
	    	
	    	
    	
    			return result;
    	}   
   
    }
}


