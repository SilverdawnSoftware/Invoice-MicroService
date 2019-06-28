// ALLOWOVERWRITE-435787F4E5CD543FA4E299406898A970-43E22022D391A3320B227FBCB8372D1D

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Entity.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Entity.Models 
{
    public partial class GetEntity : CQRSBase,IGetEntity
    { 
        [DataMember]
        public int EntityId  { get; set; }
		  	
    	 public GetEntity()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Entity.GetEntity";
        }	
	}
}

