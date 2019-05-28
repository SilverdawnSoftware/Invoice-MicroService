// ALLOWOVERWRITE-648D09527CEDCE1CEA6C748F67FE7254

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;



namespace Database.Transactions.Model
{

	[DataContract]
    public class EntityAdd
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




