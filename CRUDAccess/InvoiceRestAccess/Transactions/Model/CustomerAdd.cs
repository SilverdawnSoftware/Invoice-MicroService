// ALLOWOVERWRITE-27206A5BD97CD4FACAD6BED123B1B956

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;



namespace Database.Transactions.Model
{

	[DataContract]
    public class CustomerAdd
    {
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "active")]                
	    		public bool Active  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "customerExteranlRef")]                
	    		public string CustomerExteranlRef  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "customerId")]                
	    		public int CustomerId  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "emalAddress")]                
	    		public string EmalAddress  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "isCompany")]                
	    		public bool IsCompany  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "name")]                
	    		public string Name  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "phoneNumber")]                
	    		public string PhoneNumber  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "taxNo")]                
	    		public string TaxNo  { get; set; } 
    	   	
    	
    	/// <summary>
        /// 
        /// </summary>	
        [DataMember(Name = "entityEntityId")] 
    	public int EntityEntityId { get; set; } 
    }    	    	
}




