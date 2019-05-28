// ALLOWOVERWRITE-DE80C06763B88A2258FBB8C386A25C94

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database.Transactions.Model
{
    public class InvoiceUpdate
    {
				
				/// <summary>
                /// 
                /// </summary>	 
				public int BillngAddressAddressId  { get; set; } 				
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public DateTime CreatedDate  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public DateTime DueDate  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public string EmailTo  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public decimal GrandTotal  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public bool InvoiceEmailed  { get; set; } 
	    		
	    		/// <summary>
                /// Primary Key for Invoices
                /// </summary>	 
	    		public int InvoiceId  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public int InvoiceNo  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public string Notes  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public string OrderedBy  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public double PaidAmount  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public DateTime PaidDate  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public double PaidTax  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public string PaymentDetails  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public string PurchaseOrderRef  { get; set; } 
				
				/// <summary>
                /// 
                /// </summary>	 
				public int ShippingAddressAddressId  { get; set; } 				
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public decimal SubTotal  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public decimal Tax  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public string TermsAndConditions   { get; set; } 
    	
    }
}


