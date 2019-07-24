// ALLOWOVERWRITE-5614D87DF94FD362D1542947F22A2F42

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models 
{
    public partial interface ICounterView : ICQRSBase
    { 
         string Name  { get; set; }
		  	
         int Value  { get; set; }
		  	
	}
}



