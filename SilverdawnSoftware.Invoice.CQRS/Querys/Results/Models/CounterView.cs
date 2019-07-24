// ALLOWOVERWRITE-1AFF1A363099BA29D7A8532F2321FFE3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models 
{
    public partial class CounterView : CQRSBase,ICounterView
    { 
        [DataMember]
        public string Name  { get; set; }
		  	
        [DataMember]
        public int Value  { get; set; }
		  	
    	 public CounterView()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Results.CounterView";
        }	
	}
}

