// ALLOWOVERWRITE-8032DC41776D5BCD8C271248E022538D

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Counter.Models
{
    public partial class CounterUpdate : CQRSBase, ICounterUpdate
    { 
        /// <summary>  </summary>				
        [DataMember]	
        public string Name  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public int Value  { get; set; }
		  	
    	 public CounterUpdate()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Counter.Models.CounterUpdate";
        }	
	}
}

