// ALLOWOVERWRITE-BD2C6B80C1D15907161C771505E2CDCC

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database.Views.Model
{

    public class CustomerView
    {
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public bool  Active  { get; set; } 	    	
			    		
    		/// <summary>
            /// 
            /// </summary>	
			public string AddressPostZipCode { get; set; }   
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  CustomerExteranlRef  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public int  CustomerId  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  EmailAddress  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public bool  IsCompany  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  Name  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  PhoneNumber  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  TaxNo  { get; set; } 	    	
    						  
			/// <summary>
	        /// Reference of PrimaryKey for Entity
	        /// </summary>
			public  int EntityEntityId { get; set; }   
    	
    	
    	
	    	public static explicit operator CustomerView(Customer item)
	    	{
	    		var result=new CustomerView();
	    	 
		    	result.Active = item.Active;     
				//if (item.Address != null) 
				//{   	
				//result.AddressPostZipCode= item.Address.PostZipCode;
				//} 
		    	result.CustomerExteranlRef = item.CustomerExteranlRef;     
		    	result.CustomerId = item.CustomerId;     
		    	result.EmailAddress = item.EmailAddress;     
		    	result.IsCompany = item.IsCompany;     
		    	result.Name = item.Name;     
		    	result.PhoneNumber = item.PhoneNumber;     
		    	result.TaxNo = item.TaxNo;     
	    	
				if (item.Entity != null) 
				{   
			    	result.EntityEntityId=item.Entity.EntityId;
			    } 
	    	
    	
    			return result;
    	}   
   
    }
}



