// ALLOWOVERWRITE-6659D91B538ADCCA674290E90C32BC4C-B6EDB6DEEBB47DC84B1B4FBDB8B337CE

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Counter.Models
{
    public partial class CounterUpdate : CQRSBase, ICounterUpdate
    { 
        [DataMember]	
        public string Name  { get; set; }
		  	
        [DataMember]	
        public int Value  { get; set; }
		  	
    	 public CounterUpdate()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Counter.Models.CounterUpdate";
        }	
	}
}

