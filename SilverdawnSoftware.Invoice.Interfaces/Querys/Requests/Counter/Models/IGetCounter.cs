// ALLOWOVERWRITE-D2584501284E234E0E328FC9C46E9D23-F8388FBC7103838634C57BAE804ED53F

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Counter.Models 
{
    public partial interface IGetCounter : ICQRSBase
    { 
         string Name  { get; set; }
		  	
	}
}



