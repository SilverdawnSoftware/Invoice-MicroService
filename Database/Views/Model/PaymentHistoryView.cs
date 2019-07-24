// ALLOWOVERWRITE-B6AAAD9424CBC34EFE620FADDB10BB6E

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database.Views.Model
{

    public class PaymentHistoryView
    {
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public decimal  Amount  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public DateTime  PaymentDate  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public int  PaymentHistoryId  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  Reference  { get; set; } 	    	
    						  
			/// <summary>
	        /// Reference of PrimaryKey for Invoice
	        /// </summary>
			public  int InvoiceInvoiceId { get; set; }   
					  
					  /// <summary>
                      /// Reference to  Invoice InvoiceNo Property
                      /// </summary>	
					  public string InvoiceInvoiceNo { get; set; }   
    	
    	
    	
	    	public static explicit operator PaymentHistoryView(PaymentHistory item)
	    	{
	    		var result=new PaymentHistoryView();
	    	 
		    	result.Amount = item.Amount;     
		    	result.PaymentDate = item.PaymentDate;     
		    	result.PaymentHistoryId = item.PaymentHistoryId;     
		    	result.Reference = item.Reference;     
	    	
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



