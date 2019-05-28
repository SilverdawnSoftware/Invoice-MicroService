// ALLOWOVERWRITE-A37ED69FA883B8BCA6094625A6B59462

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Customer.Models 
{
    public partial class GetCustomer : CQRSBase,IGetCustomer
    { 
        [DataMember]
        public int CustomerId  { get; set; }
		  	
    	 public GetCustomer()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Customer.GetCustomer";
        }	
	}
}

