// ALLOWOVERWRITE-9B6B7E2F6824B718AFA25F5A474D8ACE

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database
{
    public class Invoice 
    {
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public int InvoiceId  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public DateTime CreatedDate  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public DateTime DueDate  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public DateTime PaidDate  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public decimal GrandTotal  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public decimal SubTotal  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public decimal Tax  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string OrderedBy  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string PurchaseOrderRef  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public int InvoiceNo  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public double PaidAmount  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public double PaidTax  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public bool InvoiceEmailed  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string EmailTo  { get; set; }     	
				
				/// To avoid Many to Many Relationships, use primary key https://github.com/aspnet/EntityFrameworkCore/issues/1368
				/// <summary>
                /// 
                /// </summary>	
				//public virtual Address BillngAddress  { get; set; }  
				public int BillngAddressAddressId  { get; set; } 		
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string ShippingAddress  { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string TermsAndConditions   { get; set; }     	
	    		
	    		/// <summary>  </summary>	 
	    		
	    		public string PaymentDetails  { get; set; }     	
    	
    	
    	
    	/// <summary>
        /// Reference to  Customer
        /// </summary>	
    	public virtual Customer Customer { get; set; } 
    	
    	
    	/// <summary>
        /// List of InvoiceLines
        /// </summary>	
    	public virtual List<InvoiceLine> InvoiceLines { get; set; } 
    	
    	
    	
    	
    }
    
    
}

























