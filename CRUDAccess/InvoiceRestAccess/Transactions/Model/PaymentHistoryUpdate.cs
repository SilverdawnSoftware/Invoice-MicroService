// ALLOWOVERWRITE-873BDEDE31419086F4EEC0D1CB616EB3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Database.Transactions.Model
{
	[DataContract]
    public class PaymentHistoryUpdate
    {
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "amount")]                 
	    		public decimal Amount { get; set; } 
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "paymentDate")]                 
	    		public DateTime PaymentDate { get; set; } 
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "paymentHistoryId")]                 
	    		public int PaymentHistoryId { get; set; } 
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "reference")]                 
	    		public string Reference { get; set; } 
    }
}


