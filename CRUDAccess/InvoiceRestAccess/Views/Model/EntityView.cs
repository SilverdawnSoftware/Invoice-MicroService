// ALLOWOVERWRITE-BC86BEADB5284A08D63100B3677F273E-8ED60115B004DF700DB2127CFFF8BA59

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Views.Model
{

	[DataContract]
    public class EntityView
    {
                       /// <summary>
                       /// 
                       /// </summary>
                       [DataMember(Name = "addressPostZipCode")]                         
                       public string AddressPostZipCode { get; set; }
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



