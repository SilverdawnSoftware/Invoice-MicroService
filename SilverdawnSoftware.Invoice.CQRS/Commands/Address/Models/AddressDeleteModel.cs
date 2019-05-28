// ALLOWOVERWRITE-E188217C8643D829C6A6FE599352BB85

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Address.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Address.Models
{
    public partial class AddressDelete : CQRSBase, IAddressDelete
    { 
        [DataMember]	
        public int AddressId  { get; set; }
		  	
    	 public AddressDelete()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Address.Models.AddressDelete";
        }	
	}
}

