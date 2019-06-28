// ALLOWOVERWRITE-B14E712903361826F646DB144C912334-E66D7B85D280DAFA8C7C97D8A416D1B7

using System;
using System.Collections.Generic;
using System.Linq;

namespace SilverdawnSoftware.Invoice.Database.Transactions.Model
{
    public class InvoiceLineAdd
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
        /// <summary>
        /// Primary Key for Invoices
        /// </summary>	       
        public int InvoiceInvoiceId { get; set; } 
    }    	    	
}




