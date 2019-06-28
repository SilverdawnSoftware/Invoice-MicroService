// ALLOWOVERWRITE-E8436FE18A6AC93642A5F8754FF29D6F-1DB9B43EE286ADB8EB4C2AC4E55EA413

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter.Models
{
    public partial interface ICounterAdd : ICQRSBase
    { 
         string Name  { get; set; }
		  	
         int Value  { get; set; }
		  	
	}
}

