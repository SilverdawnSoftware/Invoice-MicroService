// ALLOWOVERWRITE-BB0874C41233B2499F4E594A15282FA1

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database.Transactions.Model
{
    public class PaymentHistoryAdd
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
    	   	
    	
    	/// <summary>
        /// Primary Key for Invoices
        /// </summary>	
       
    	public int InvoiceInvoiceId { get; set; } 
    }    	    	
}




