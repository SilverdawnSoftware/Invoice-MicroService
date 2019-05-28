// ALLOWOVERWRITE-23B441A8F038488474E6155DF72D985C

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customer.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Customer.Models
{
    public partial class CustomerDelete : CQRSBase, ICustomerDelete
    { 
        [DataMember]	
        public int CustomerId  { get; set; }
		  	
    	 public CustomerDelete()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Customer.Models.CustomerDelete";
        }	
	}
}

