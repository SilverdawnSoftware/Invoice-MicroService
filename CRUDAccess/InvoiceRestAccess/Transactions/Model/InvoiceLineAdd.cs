// ALLOWOVERWRITE-66CF068CBFA3EF1C8F7A2D002DA3D874

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
        /// 
        /// </summary>	
        [DataMember(Name = "invoiceInvoiceId")] 
    	public int InvoiceInvoiceId { get; set; } 
    }    	    	
}



