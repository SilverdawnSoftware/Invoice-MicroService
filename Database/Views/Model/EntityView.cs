// ALLOWOVERWRITE-773CC7A2E7037EA5971F945CBBE05A50-4A05B4E889A0C23DC85A73E06B92CE81

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
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  SMTPEmailDisplayName  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  SMTPEmailFromAddress  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  SMTPHost  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  SMTPPassword  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  SMTPUserName  { get; set; } 	    	
    	    	
    	
    	
	    	public static explicit operator EntityView(Entity item)
	    	{
	    		var result=new EntityView();
	    	 
				//if (item.Address != null) 
				//{   	
				//result.AddressPostZipCode= item.Address.PostZipCode;
				//} 
		    	result.EntityExternalRef = item.EntityExternalRef;     
		    	result.EntityId = item.EntityId;     
		    	result.LogoURL = item.LogoURL;     
		    	result.Name = item.Name;     
		    	result.SMTPEmailDisplayName = item.SMTPEmailDisplayName;     
		    	result.SMTPEmailFromAddress = item.SMTPEmailFromAddress;     
		    	result.SMTPHost = item.SMTPHost;     
		    	result.SMTPPassword = item.SMTPPassword;     
		    	result.SMTPUserName = item.SMTPUserName;     
	    	
	    	
    	
    			return result;
    	}   
   
    }
}



