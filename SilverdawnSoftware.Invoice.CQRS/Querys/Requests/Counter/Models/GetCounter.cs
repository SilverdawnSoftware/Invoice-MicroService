// ALLOWOVERWRITE-F181DC4231664FDF5387C1F236765973

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Counter.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Counter.Models 
{
    public partial class GetCounter : CQRSBase,IGetCounter
    { 
        [DataMember]
        public string Name  { get; set; }
		  	
    	 public GetCounter()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Counter.GetCounter";
        }	
	}
}

