// ALLOWOVERWRITE-922CB2680F8507DF12646C8EC224531F

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Views.Model
{

	[DataContract]
    public class InvoiceView
    {
                       /// <summary>
                       ///  
                       /// </summary>	
                       [DataMember(Name = "billngAddressAddressId")]
                       public int BillngAddressAddressId { get; set; } 
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "billngAddressPostZipCode")]                         
                       public string BillngAddressPostZipCode { get; set; }
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "createdDate")]            
                       public DateTime CreatedDate { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "dueDate")]            
                       public DateTime DueDate { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "emailTo")]            
                       public string EmailTo { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "grandTotal")]            
                       public decimal GrandTotal { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "invoiceEmailed")]            
                       public bool InvoiceEmailed { get; set; }	    	
                       /// <summary>
                       /// Primary Key for Invoices
                       /// </summary>
                       [DataMember(Name = "invoiceId")]            
                       public int InvoiceId { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "invoiceNo")]            
                       public int InvoiceNo { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "notes")]            
                       public string Notes { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "orderedBy")]            
                       public string OrderedBy { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "paidAmount")]            
                       public double PaidAmount { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "paidDate")]            
                       public DateTime PaidDate { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "paidTax")]            
                       public double PaidTax { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "paymentDetails")]            
                       public string PaymentDetails { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "purchaseOrderRef")]            
                       public string PurchaseOrderRef { get; set; }	    	
                       /// <summary>
                       ///  
                       /// </summary>	
                       [DataMember(Name = "shippingAddressAddressId")]
                       public int ShippingAddressAddressId { get; set; } 
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "shippingAddressPostZipCode")]                         
                       public string ShippingAddressPostZipCode { get; set; }
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "status")]            
                       public int Status { get; set; }		    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "subTotal")]            
                       public decimal SubTotal { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "tax")]            
                       public decimal Tax { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "termsAndConditions ")]            
                       public string TermsAndConditions  { get; set; }	    	
    						  
					   /// <summary>
                      /// Reference of PrimaryKey for Customer
                      /// </summary>
                      [DataMember(Name = "customerCustomerId")]
					  public  int CustomerCustomerId { get; set; }   
					  
					  /// <summary>
                      /// Reference to  Customer Name Property
                      /// </summary>
				      [DataMember(Name = "customerName")]                      
					  public string CustomerName { get; set; }   
    	
    	
    	
    	
   
    }
}



