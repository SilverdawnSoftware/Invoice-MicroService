// ALLOWOVERWRITE-7CE30B8051A3164F8701BC2B8FF0F2B3

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database.Transactions.Model
{
    public class PaymentHistoryUpdate
    {
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public decimal Amount  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public DateTime PaymentDate  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public int PaymentHistoryId  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public string Reference  { get; set; } 
    	
    }
}


