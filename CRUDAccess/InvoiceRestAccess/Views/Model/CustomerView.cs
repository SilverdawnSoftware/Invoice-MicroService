// ALLOWOVERWRITE-72DB9DEFF6267724AF8B697B1462B4EA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Views.Model
{

	[DataContract]
    public class CustomerView
    {
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "active")]            
                       public bool Active { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "addressPostZipCode")]                         
                       public string AddressPostZipCode { get; set; }
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "customerExteranlRef")]            
                       public string CustomerExteranlRef { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "customerId")]            
                       public int CustomerId { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "emailAddress")]            
                       public string EmailAddress { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "isCompany")]            
                       public bool IsCompany { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "name")]            
                       public string Name { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "phoneNumber")]            
                       public string PhoneNumber { get; set; }	    	
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "taxNo")]            
                       public string TaxNo { get; set; }	    	
    						  
					   /// <summary>
                      /// Reference of PrimaryKey for Entity
                      /// </summary>
                      [DataMember(Name = "entityEntityId")]
					  public  int EntityEntityId { get; set; }   
    	
    	
    	
    	
   
    }
}



