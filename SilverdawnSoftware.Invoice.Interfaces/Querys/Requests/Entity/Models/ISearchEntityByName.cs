// ALLOWOVERWRITE-652603B3B7C9A6A18D4D33360E72CAF7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Entity.Models 
{
    public partial interface ISearchEntityByName : ICQRSBase
    { 
         string Name  { get; set; }
		  	
	}
}



