// ALLOWOVERWRITE-8599516155507CA5AB0BDFD993B6B336

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database.Views.Model
{

    public class InvoiceLineView
    {
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public int  InvoiceLineId  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public decimal  LineTotal  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  Notes  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  Product  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  ProductCode  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public double  Quantity  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public decimal  SubTotal  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public bool  TaxExempt  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public decimal  TaxTotal  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public decimal  UnitCost  { get; set; } 	    	
    						  
			/// <summary>
	        /// Reference of PrimaryKey for Invoice
	        /// </summary>
			public  int InvoiceInvoiceId { get; set; }   
					  
					  /// <summary>
                      /// Reference to  Invoice InvoiceNo Property
                      /// </summary>	
					  public string InvoiceInvoiceNo { get; set; }   
    	
    	
    	
	    	public static explicit operator InvoiceLineView(InvoiceLine item)
	    	{
	    		var result=new InvoiceLineView();
	    	 
		    	result.InvoiceLineId = item.InvoiceLineId;     
		    	result.LineTotal = item.LineTotal;     
		    	result.Notes = item.Notes;     
		    	result.Product = item.Product;     
		    	result.ProductCode = item.ProductCode;     
		    	result.Quantity = item.Quantity;     
		    	result.SubTotal = item.SubTotal;     
		    	result.TaxExempt = item.TaxExempt;     
		    	result.TaxTotal = item.TaxTotal;     
		    	result.UnitCost = item.UnitCost;     
	    	
				if (item.Invoice != null) 
				{   
			    	result.InvoiceInvoiceId=item.Invoice.InvoiceId;
			    } 
			    		if (item.Invoice != null) 
				    			{   	
			    			result.InvoiceInvoiceNo=item.Invoice.InvoiceNo.ToString(); 
			    			} 
	    	
    	
    			return result;
    	}   
   
    }
}


