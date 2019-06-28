// ALLOWOVERWRITE-50731FB5A9B633963123633C1F987569-65070F796A42796C0F76B66E35A64367

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Database.Transactions.Model
{
	[DataContract]
    public class CustomerUpdate
    {
              /// <summary>
              ///  
              /// </summary>
              [DataMember(Name = "active")]                 
              public bool Active { get; set; } 
              /// <summary>
              ///  
              /// </summary>
              //[DataMember(Name = "address")]                 
             // public Address Address { get; set; } 	
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
    }
}


