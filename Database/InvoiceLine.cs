// ALLOWOVERWRITE-3787146AD5D9875667371DBF0A1CC402

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database
{
    public class InvoiceLine 
    {
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public int InvoiceLineId  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public double Quantity  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public decimal UnitCost  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public decimal SubTotal  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public decimal TaxTotal  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public decimal LineTotal  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string Product  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public bool TaxExempt  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string ProductCode  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string Notes  { get; set; }     	
    	
    	
    	
    	/// <summary>
        /// Reference to  Invoice
        /// </summary>	
    	public virtual Invoice Invoice { get; set; } 
    	
    	
    	
    	
    	
    }
    
    
}

























