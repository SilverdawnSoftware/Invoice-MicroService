// ALLOWOVERWRITE-B00C7513A3EA2013ADD63837216F6371

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Database.Transactions.Model
{
	[DataContract]
    public class EntityUpdate
    {
              /// <summary>
              ///  
              /// </summary>
              //[DataMember(Name = "address")]                 
             // public Address Address { get; set; } 	
              /// <summary>
              ///  
              /// </summary>
              [DataMember(Name = "entityExternalRef")]                 
              public string EntityExternalRef { get; set; } 
              /// <summary>
              ///  
              /// </summary>
              [DataMember(Name = "entityId")]                 
              public int EntityId { get; set; } 
              /// <summary>
              ///  
              /// </summary>
              [DataMember(Name = "logoURL")]                 
              public string LogoURL { get; set; } 
              /// <summary>
              ///  
              /// </summary>
              [DataMember(Name = "name")]                 
              public string Name { get; set; } 
              /// <summary>
              ///  
              /// </summary>
              [DataMember(Name = "sMTPEmailDisplayName")]                 
              public string SMTPEmailDisplayName { get; set; } 
              /// <summary>
              ///  
              /// </summary>
              [DataMember(Name = "sMTPEmailFromAddress")]                 
              public string SMTPEmailFromAddress { get; set; } 
              /// <summary>
              ///  
              /// </summary>
              [DataMember(Name = "sMTPHost")]                 
              public string SMTPHost { get; set; } 
              /// <summary>
              ///  
              /// </summary>
              [DataMember(Name = "sMTPPassword")]                 
              public string SMTPPassword { get; set; } 
              /// <summary>
              ///  
              /// </summary>
              [DataMember(Name = "sMTPUserName")]                 
              public string SMTPUserName { get; set; } 
    }
}


