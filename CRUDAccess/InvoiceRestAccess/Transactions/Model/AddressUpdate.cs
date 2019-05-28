// ALLOWOVERWRITE-D7FB4114157079E2325D8EC90469BEF5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Transactions.Model
{
	[DataContract]
    public class AddressUpdate
    {
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "addresLine2")]                 
	    		public string AddresLine2  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "addressExternalRef")]                 
	    		public string AddressExternalRef  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "addressId")]                 
	    		public int AddressId  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "addressLine1")]                 
	    		public string AddressLine1  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "addressLine3")]                 
	    		public string AddressLine3  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "city")]                 
	    		public string City  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "country")]                 
	    		public string Country  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "postZipCode")]                 
	    		public string PostZipCode  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "stateCounty")]                 
	    		public string StateCounty  { get; set; } 
    	
    }
}


