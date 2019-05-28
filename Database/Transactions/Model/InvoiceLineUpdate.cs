// ALLOWOVERWRITE-BCA210BA21097B841AB391092F9F8856

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database.Transactions.Model
{
    public class InvoiceLineUpdate
    {
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public int InvoiceLineId  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public decimal LineTotal  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public string Notes  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public string Product  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public string ProductCode  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public double Quantity  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public decimal SubTotal  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public bool TaxExempt  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public decimal TaxTotal  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public decimal UnitCost  { get; set; } 
    	
    }
}


