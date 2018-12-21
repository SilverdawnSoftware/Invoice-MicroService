// ALLOWOVERWRITE-70829EC45CA9921964C100AC75688A48

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
                /// 
                /// </summary>	 
	    		public int InvoiceId  { get; set; } 
	    		
	    		/// <summary>
                /// 
                /// </summary>	 
	    		public int InvoiceNo  { get; set; } 
	    		
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
	    		public string ShippingAddress  { get; set; } 
	    		
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

