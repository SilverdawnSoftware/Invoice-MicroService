// ALLOWOVERWRITE-3960D7E1B44FA4F2EAA0FDCB155AF052

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models
{
    public partial class EntityDelete : CQRSBase, IEntityDelete
    { 
        /// <summary>  </summary>				
        [DataMember]	
        public int EntityId  { get; set; }
		  	
    	 public EntityDelete()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models.EntityDelete";
        }	
	}
}

