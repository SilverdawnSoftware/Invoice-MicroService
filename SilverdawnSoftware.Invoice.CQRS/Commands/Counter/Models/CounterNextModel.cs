// ALLOWOVERWRITE-0F8EE2DD66220549025FA956BE94E892

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Counter.Models
{
    public partial class CounterNext : CQRSBase, ICounterNext
    { 
        /// <summary>  </summary>				
        [DataMember]	
        public string Name  { get; set; }
		  	
    	 public CounterNext()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Counter.Models.CounterNext";
        }	
	}
}

