// ALLOWOVERWRITE-EC2587AB89EF4C56CE94CC33EE596417

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace Database.Transactions.Model
{
	[DataContract]
    public class PaymentHistoryAdd
    {
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "amount")]                
	    		public decimal Amount  { get; set; } 
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "paymentDate")]                
	    		public DateTime PaymentDate  { get; set; } 
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "paymentHistoryId")]                
	    		public int PaymentHistoryId  { get; set; } 
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "reference")]                
	    		public string Reference  { get; set; } 
    	/// <summary>
        /// Primary Key for Invoices
        /// </summary>	
        [DataMember(Name = "invoiceInvoiceId")] 
    	public int InvoiceInvoiceId { get; set; }
    }    	    	
}




