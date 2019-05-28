// ALLOWOVERWRITE-A4E6A7DD1DF2BB6599D1E3F03056865E

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Customer.Models 
{
    public partial class GetAddressesForCustomer : CQRSBase,IGetAddressesForCustomer
    { 
        [DataMember]
        public int CustomerId  { get; set; }
		  	
    	 public GetAddressesForCustomer()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Customer.GetAddressesForCustomer";
        }	
	}
}

