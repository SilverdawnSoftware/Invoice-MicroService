// ALLOWOVERWRITE-EECF1E968CB9AC1ED5F952B4CA5B8664-927C55DBC3DFA41F72F33C962B954C0C

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Counter.Models
{
    public partial class CounterAdd : CQRSBase, ICounterAdd
    { 
        [DataMember]	
        public string Name  { get; set; }
		  	
        [DataMember]	
        public int Value  { get; set; }
		  	
    	 public CounterAdd()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Counter.Models.CounterAdd";
        }	
	}
}

