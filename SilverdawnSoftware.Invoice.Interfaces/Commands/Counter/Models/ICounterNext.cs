// ALLOWOVERWRITE-A56030EFEE1BAF08AE78824F3DC63DAE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter.Models
{
    public partial interface ICounterNext : ICQRSBase
    { 
         string Name  { get; set; }
		  	
	}
}

