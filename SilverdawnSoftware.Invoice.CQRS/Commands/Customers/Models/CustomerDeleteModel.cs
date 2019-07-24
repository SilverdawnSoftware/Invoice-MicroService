// ALLOWOVERWRITE-9F498122EE205D174B254752A638726A

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customer.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Customer.Models
{
    public partial class CustomerDelete : CQRSBase, ICustomerDelete
    { 
        /// <summary>  </summary>				
        [DataMember]	
        public int CustomerId  { get; set; }
		  	
    	 public CustomerDelete()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Customer.Models.CustomerDelete";
        }	
	}
}

