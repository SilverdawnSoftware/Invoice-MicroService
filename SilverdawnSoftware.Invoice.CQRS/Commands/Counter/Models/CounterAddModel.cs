// ALLOWOVERWRITE-A9982CFEF4DC4D6EE904785BED66C421

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Counter.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Counter.Models
{
    public partial class CounterAdd : CQRSBase, ICounterAdd
    { 
        /// <summary>  </summary>				
        [DataMember]	
        public string Name  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public int Value  { get; set; }
		  	
    	 public CounterAdd()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Counter.Models.CounterAdd";
        }	
	}
}

