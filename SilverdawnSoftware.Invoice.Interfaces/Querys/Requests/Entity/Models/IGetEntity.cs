// ALLOWOVERWRITE-2C83129168A2A40C046570094362FD63-76C2EBF6141D7D0EF75E7493902B3EAF

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Entity.Models 
{
    public partial interface IGetEntity : ICQRSBase
    { 
         int EntityId  { get; set; }
		  	
	}
}



