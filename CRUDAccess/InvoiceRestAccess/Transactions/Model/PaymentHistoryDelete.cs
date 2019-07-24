// ALLOWOVERWRITE-A3069F032371EC75C0BF92550EC4B166

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Transactions.Model
{
	[DataContract]
    public class PaymentHistoryDelete
    {
    	
    	
    	/// <summary>
        /// 
        /// </summary>
		 [DataMember(Name = "paymentHistoryId")]         
    	public int  PaymentHistoryId  { get; set; } 
    	
    }
}
