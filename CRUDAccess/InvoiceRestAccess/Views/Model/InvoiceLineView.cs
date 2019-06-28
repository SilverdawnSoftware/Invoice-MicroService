// ALLOWOVERWRITE-9615597BE36CD5B27BE6FD34BFA264BA-E2D235D55571F3F63B9C01C55A8D368C

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Views.Model
{

	[DataContract]
    public class InvoiceLineView
    {
    
   
    
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "invoiceLineId")]            
	    	public int  InvoiceLineId  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "lineTotal")]            
	    	public decimal  LineTotal  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "notes")]            
	    	public string  Notes  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "product")]            
	    	public string  Product  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "productCode")]            
	    	public string  ProductCode  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "quantity")]            
	    	public double  Quantity  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "subTotal")]            
	    	public decimal  SubTotal  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "taxExempt")]            
	    	public bool  TaxExempt  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "taxTotal")]            
	    	public decimal  TaxTotal  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>
			 [DataMember(Name = "unitCost")]            
	    	public decimal  UnitCost  { get; set; } 	    	
    						  
					   /// <summary>
                      /// Reference of PrimaryKey for Invoice
                      /// </summary>
                      [DataMember(Name = "invoiceInvoiceId")]
					  public  int InvoiceInvoiceId { get; set; }   
					  
					  /// <summary>
                      /// Reference to  Invoice InvoiceNo Property
                      /// </summary>
				      [DataMember(Name = "invoiceInvoiceNo")]                      
					  public string InvoiceInvoiceNo { get; set; }   
    	
    	
    	
    	
   
    }
}



