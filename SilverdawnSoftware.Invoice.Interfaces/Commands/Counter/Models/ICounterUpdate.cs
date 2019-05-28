// ALLOWOVERWRITE-692A22DF0F6DBF3CF3BF708034C4DCFC

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter.Models
{
    public partial interface ICounterUpdate : ICQRSBase
    { 
         string Name  { get; set; }
		  	
         int Value  { get; set; }
		  	
	}
}

