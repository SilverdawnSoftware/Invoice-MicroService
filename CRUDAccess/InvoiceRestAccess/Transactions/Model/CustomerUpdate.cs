// ALLOWOVERWRITE-CA9CF62CB9B37ACA5F6F3AEBE3DFC9AB

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Transactions.Model
{
	[DataContract]
    public class CustomerUpdate
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
    	
    }
}

