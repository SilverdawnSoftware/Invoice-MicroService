// ALLOWOVERWRITE-F635E7C730AE8E8D763AFCF5134879F5-D381104C9181600260ED3C038E9284DE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;



namespace Database.Transactions.Model
{

	[DataContract]
    public class InvoiceLineAdd
    {
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "invoiceLineId")]                
	    		public int InvoiceLineId  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "lineTotal")]                
	    		public decimal LineTotal  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "notes")]                
	    		public string Notes  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "product")]                
	    		public string Product  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "productCode")]                
	    		public string ProductCode  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "quantity")]                
	    		public double Quantity  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "subTotal")]                
	    		public decimal SubTotal  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "taxExempt")]                
	    		public bool TaxExempt  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "taxTotal")]                
	    		public decimal TaxTotal  { get; set; } 
	    		
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "unitCost")]                
	    		public decimal UnitCost  { get; set; } 
    	   	
    	
    	/// <summary>
        /// Primary Key for Invoices
        /// </summary>	
        [DataMember(Name = "invoiceInvoiceId")] 
    	public int InvoiceInvoiceId { get; set; } 
    }    	    	
}




