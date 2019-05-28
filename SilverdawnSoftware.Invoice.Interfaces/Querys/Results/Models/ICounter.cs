// ALLOWOVERWRITE-F4D1431571BE57C9D10DF27E290A630E

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models 
{
    public partial interface ICounter : ICQRSBase
    { 
         string Name  { get; set; }
		  	
         int Value  { get; set; }
		  	
	}
}



