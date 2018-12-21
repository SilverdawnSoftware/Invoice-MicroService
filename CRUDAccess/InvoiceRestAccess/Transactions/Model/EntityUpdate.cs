// ALLOWOVERWRITE-7241AC9A90CE306CE1E5A65198382A66

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Transactions.Model
{
	[DataContract]
    public class EntityUpdate
    {
				
				/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "addressAddressId")]                 
				public int AddressAddressId  { get; set; } 				
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "entityExternalRef")]                 
	    		public string EntityExternalRef  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "entityId")]                 
	    		public int EntityId  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "logoURL")]                 
	    		public string LogoURL  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "name")]                 
	    		public string Name  { get; set; } 
    	
    }
}

