// ALLOWOVERWRITE-2FE1A11AFE0FB508C81C274B74EFEC0A

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models
{
    public partial class EntityDelete : CQRSBase, IEntityDelete
    { 
        [DataMember]	
        public int EntityId  { get; set; }
		  	
    	 public EntityDelete()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models.EntityDelete";
        }	
	}
}

