// ALLOWOVERWRITE-577C782334D6A98229F212DF77DD0108-15612A727C360F30F0DAF9449F820789

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
              //[DataMember(Name = "address")]                 
             // public Address Address { get; set; } 	
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
				[DataMember(Name = "emailAddress")]                
	    		public string EmailAddress  { get; set; } 
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




