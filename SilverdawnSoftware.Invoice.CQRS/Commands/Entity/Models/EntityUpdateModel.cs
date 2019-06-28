// ALLOWOVERWRITE-6A8EC44A55AB5236A026013469772B90-30F122257FD35F11AE05607E784A265B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models
{
    public partial class EntityUpdate : CQRSBase, IEntityUpdate
    { 
        [DataMember]	
        public int EntityId  { get; set; }
		  	
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
		  	
    	 public EntityUpdate()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models.EntityUpdate";
        }	
	}
}

