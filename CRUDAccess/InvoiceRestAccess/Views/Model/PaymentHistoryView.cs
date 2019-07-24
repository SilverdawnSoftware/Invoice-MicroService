// ALLOWOVERWRITE-AF6240ECAC95061BC0BCD88AFA6E21FA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Views.Model
{

	[DataContract]
    public class PaymentHistoryView
    {
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "amount")]            
                       public decimal Amount { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "paymentDate")]            
                       public DateTime PaymentDate { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "paymentHistoryId")]            
                       public int PaymentHistoryId { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "reference")]            
                       public string Reference { get; set; }	    	
    						  
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



