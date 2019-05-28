// ALLOWOVERWRITE-25CA44CB035C4AD6DE07B30561212BFB

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Views.Model
{

	[DataContract]
    public class EntityView
    {
    
   
    
			    		
			    		/// <summary>
                        ///  
                        /// </summary>	
			    		 [DataMember(Name = "addressAddressId")]
			    		public int AddressAddressId { get; set; }   
			    		
			    		/// <summary>
                        /// 
                         /// </summary>
						 [DataMember(Name = "addressPostZipCode")]                         
			    		public string AddressPostZipCode { get; set; }   
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "entityExternalRef")]            
	    	public string  EntityExternalRef  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "entityId")]            
	    	public int  EntityId  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "logoURL")]            
	    	public string  LogoURL  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "name")]            
	    	public string  Name  { get; set; } 	    	
    	    	
    	
    	
    	
   
    }
}



