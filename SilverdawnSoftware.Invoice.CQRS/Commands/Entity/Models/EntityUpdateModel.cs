// ALLOWOVERWRITE-E664ABAC278CFBB0DAA86645F74CD7FE

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
        /// <summary>  </summary>				
        [DataMember]	
        public int EntityId  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public string Name  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public string EntityExternalRef  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public IAddressView Address { get; set; }						
        /// <summary>  </summary>				
        [DataMember]	
        public string LogoURL  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public string SMTPEmailFromAddress  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public string SMTPUserName  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public string SMTPPassword  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public string SMTPHost  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public string SMTPEmailDisplayName  { get; set; }
		  	
    	 public EntityUpdate()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models.EntityUpdate";
        }	
	}
}

