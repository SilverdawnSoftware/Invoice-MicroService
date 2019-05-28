// ALLOWOVERWRITE-B5D5474EA3187D161B37DDDC64CF65D0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Transactions.Model
{
	[DataContract]
    public class CustomerDelete
    {
    	
    	
    	/// <summary>
        /// 
        /// </summary>
		 [DataMember(Name = "customerId")]         
    	public int  CustomerId  { get; set; } 
    	
    }
}
