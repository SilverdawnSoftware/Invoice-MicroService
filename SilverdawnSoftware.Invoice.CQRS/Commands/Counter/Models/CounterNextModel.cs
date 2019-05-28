// ALLOWOVERWRITE-9F5F3013762105A252B2A8356E282A6D

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Counter.Models
{
    public partial class CounterNext : CQRSBase, ICounterNext
    { 
        [DataMember]	
        public string Name  { get; set; }
		  	
    	 public CounterNext()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Counter.Models.CounterNext";
        }	
	}
}

