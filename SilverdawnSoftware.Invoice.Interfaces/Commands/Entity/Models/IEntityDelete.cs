// ALLOWOVERWRITE-FD1660302DE9F37E00E9183213BAFEAE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity.Models
{
    public partial interface IEntityDelete : ICQRSBase
    { 
         int EntityId  { get; set; }
		  	
	}
}

