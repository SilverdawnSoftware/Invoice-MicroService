// ALLOWOVERWRITE-42CDC58ADA6D75C1C25B79872927808A

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Address.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Address.Models 
{
    public partial class GetAddress : CQRSBase,IGetAddress
    { 
        [DataMember]
        public int AddressId  { get; set; }
		  	
    	 public GetAddress()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Address.GetAddress";
        }	
	}
}

