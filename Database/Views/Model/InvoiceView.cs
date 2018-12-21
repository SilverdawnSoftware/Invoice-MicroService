// ALLOWOVERWRITE-AEBDA472849818066E89DE50A8DB39B2

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database.Views.Model
{

    public class InvoiceView
    {
			    		
    		/// <summary>
            ///  
            /// </summary>	
			    		
			public int BillngAddressAddressId { get; set; }   
			    		
    		/// <summary>
            /// 
            /// </summary>	
			public string BillngAddressPostZipCode { get; set; }   
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public DateTime  CreatedDate  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public DateTime  DueDate  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  EmailTo  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public decimal  GrandTotal  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public bool  InvoiceEmailed  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public int  InvoiceId  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public int  InvoiceNo  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  OrderedBy  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public double  PaidAmount  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public DateTime  PaidDate  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public double  PaidTax  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  PaymentDetails  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  PurchaseOrderRef  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  ShippingAddress  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public decimal  SubTotal  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public decimal  Tax  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  TermsAndConditions   { get; set; } 	    	
    						  
			/// <summary>
	        /// Reference of PrimaryKey for Customer
	        /// </summary>
			public  int CustomerCustomerId { get; set; }   
					  
					  /// <summary>
                      /// Reference to  Customer Name Property
                      /// </summary>	
					  public string CustomerName { get; set; }   
    	
    	
    	
	    	public static explicit operator InvoiceView(Invoice item)
	    	{
	    		var result=new InvoiceView();
	    	 
				//if (item.BillngAddress != null) 
				//{   	
				result.BillngAddressAddressId= item.BillngAddressAddressId;
				//result.BillngAddressAddressId= item.BillngAddress.AddressId;
				//} 
				//if (item.BillngAddress != null) 
				//{   	
				//result.BillngAddressPostZipCode= item.BillngAddress.PostZipCode;
				//} 
		    	result.CreatedDate = item.CreatedDate;     
		    	result.DueDate = item.DueDate;     
		    	result.EmailTo = item.EmailTo;     
		    	result.GrandTotal = item.GrandTotal;     
		    	result.InvoiceEmailed = item.InvoiceEmailed;     
		    	result.InvoiceId = item.InvoiceId;     
		    	result.InvoiceNo = item.InvoiceNo;     
		    	result.OrderedBy = item.OrderedBy;     
		    	result.PaidAmount = item.PaidAmount;     
		    	result.PaidDate = item.PaidDate;     
		    	result.PaidTax = item.PaidTax;     
		    	result.PaymentDetails = item.PaymentDetails;     
		    	result.PurchaseOrderRef = item.PurchaseOrderRef;     
		    	result.ShippingAddress = item.ShippingAddress;     
		    	result.SubTotal = item.SubTotal;     
		    	result.Tax = item.Tax;     
		    	result.TermsAndConditions  = item.TermsAndConditions ;     
	    	
				if (item.Customer != null) 
				{   
			    	result.CustomerCustomerId=item.Customer.CustomerId;
			    } 
			    		if (item.Customer != null) 
				    			{   	
			    			result.CustomerName=item.Customer.Name.ToString(); 
			    			} 
	    	
    	
    			return result;
    	}   
   
    }
}


