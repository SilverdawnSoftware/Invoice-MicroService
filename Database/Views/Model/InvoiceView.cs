// ALLOWOVERWRITE-1035DBB71F3CE041796BB0E9B79CA4A5

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database.Views.Model
{

    public class InvoiceView
    {
			    		
    		/// <summary>
            /// The address when the invoice is to be billed to.
            /// </summary>	
			public string BillingAddressPostZipCode { get; set; }   
	    	
	    	
	    	/// <summary>
            /// This is the date the invoice was created
            /// </summary>	
	    	public DateTime  CreatedDate  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// This is the date the invoice is due to paid
            /// </summary>	
	    	public DateTime  DueDate  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// Who the invoice is to be emailed to.
            /// </summary>	
	    	public string  EmailTo  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// This is the total of all the invoice lines + tax 
            /// </summary>	
	    	public decimal  GrandTotal  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// Flag to indicate if the invoice has been emailed to the client
            /// </summary>	
	    	public bool  InvoiceEmailed  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// Primary Key for Invoices
            /// </summary>	
	    	public int  InvoiceId  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// The Invoice No. This number is auto-incremented from the counters table. 
            /// </summary>	
	    	public int  InvoiceNo  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// Any extra information to be applied to the invoice.
            /// </summary>	
	    	public string  Notes  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// The person who placed this order
            /// </summary>	
	    	public string  OrderedBy  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// How much of the invoice that has been paid
            /// </summary>	
	    	public double  PaidAmount  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// This is the date the invoice was fully paid off
            /// </summary>	
	    	public DateTime  PaidDate  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// How much of the invoice tax that has been paid.
            /// </summary>	
	    	public double  PaidTax  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// What terms the invocie should be paid againist. e.g. Full payment in 30 days,
            /// </summary>	
	    	public string  PaymentDetails  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// Customer Purchase Order Reference for the Invoice
            /// </summary>	
	    	public string  PurchaseOrderRef  { get; set; } 	    	
			    		
    		/// <summary>
            /// The locaiton when the invoice goods are to be shipped to.
            /// </summary>	
			public string ShippingAddressPostZipCode { get; set; }   
	    	
	    	
	    	/// <summary>
            /// This is the total of all the invoice lines less tax
            /// </summary>	
	    	public decimal  SubTotal  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// This is the total of the tax for invoice line
            /// </summary>	
	    	public decimal  TaxTotal  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// Any terms and conditions for the invoices. These can be added to the bottom of the invoice
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
	    	 
				//if (item.BillingAddress != null) 
				//{   	
				//result.BillingAddressPostZipCode= item.BillingAddress.PostZipCode;
				//} 
		    	result.CreatedDate = item.CreatedDate;     
		    	result.DueDate = item.DueDate;     
		    	result.EmailTo = item.EmailTo;     
		    	result.GrandTotal = item.GrandTotal;     
		    	result.InvoiceEmailed = item.InvoiceEmailed;     
		    	result.InvoiceId = item.InvoiceId;     
		    	result.InvoiceNo = item.InvoiceNo;     
		    	result.Notes = item.Notes;     
		    	result.OrderedBy = item.OrderedBy;     
		    	result.PaidAmount = item.PaidAmount;     
		    	result.PaidDate = item.PaidDate;     
		    	result.PaidTax = item.PaidTax;     
		    	result.PaymentDetails = item.PaymentDetails;     
		    	result.PurchaseOrderRef = item.PurchaseOrderRef;     
				//if (item.ShippingAddress != null) 
				//{   	
				//result.ShippingAddressPostZipCode= item.ShippingAddress.PostZipCode;
				//} 
		    	result.SubTotal = item.SubTotal;     
		    	result.TaxTotal = item.TaxTotal;     
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



