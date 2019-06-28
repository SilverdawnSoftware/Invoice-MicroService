// ALLOWOVERWRITE-7CEFEA583A5162C19AD463DDD105CEDF-A36828001E99DC119BDA45BE15C1B853

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models
{
    public partial class EntityAdd : CQRSBase, IEntityAdd
    { 
        [DataMember]	
        public string Name  { get; set; }
		  	
        [DataMember]	
        public string EntityExternalRef  { get; set; }
		  	
        [DataMember]	
        public IAddressView Address { get; set; }						
        [DataMember]	
        public string LogoURL  { get; set; }
		  	
        [DataMember]	
        public string SMTPEmailFromAddress  { get; set; }
		  	
        [DataMember]	
        public string SMTPUserName  { get; set; }
		  	
        [DataMember]	
        public string SMTPPassword  { get; set; }
		  	
        [DataMember]	
        public string SMTPHost  { get; set; }
		  	
        [DataMember]	
        public string SMTPEmailDisplayName  { get; set; }
		  	
    	 public EntityAdd()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models.EntityAdd";
        }	
	}
}

