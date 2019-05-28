// ALLOWOVERWRITE-72D9C94AC21BA4F8BAB3D3D3B9A896A6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Views.Model
{

	[DataContract]
    public class AddressView
    {
    
   
    
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "addresLine2")]            
	    	public string  AddresLine2  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "addressExternalRef")]            
	    	public string  AddressExternalRef  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "addressId")]            
	    	public int  AddressId  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "addressLine1")]            
	    	public string  AddressLine1  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "addressLine3")]            
	    	public string  AddressLine3  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "city")]            
	    	public string  City  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "country")]            
	    	public string  Country  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "postZipCode")]            
	    	public string  PostZipCode  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "stateCounty")]            
	    	public string  StateCounty  { get; set; } 	    	
    						  
					   /// <summary>
                      /// Reference of PrimaryKey for Customer
                      /// </summary>
                      [DataMember(Name = "customerCustomerId")]
					  public  int CustomerCustomerId { get; set; }   
					  
					  /// <summary>
                      /// Reference to  Customer Name Property
                      /// </summary>
				      [DataMember(Name = "customerName")]                      
					  public string CustomerName { get; set; }   
    	
    	
    	
    	
   
    }
}



