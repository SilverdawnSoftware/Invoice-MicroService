// ALLOWOVERWRITE-340E5C54E5B89063229C7994AED17736

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Address.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Address.Models
{
    public partial class AddressUpdate : CQRSBase, IAddressUpdate
    { 
        [DataMember]	
        public int AddressId  { get; set; }
		  	
        [DataMember]	
        public string AddressLine1  { get; set; }
		  	
        [DataMember]	
        public string AddresLine2  { get; set; }
		  	
        [DataMember]	
        public string City  { get; set; }
		  	
        [DataMember]	
        public string PostZipCode  { get; set; }
		  	
        [DataMember]	
        public string StateCounty  { get; set; }
		  	
        [DataMember]	
        public string Country  { get; set; }
		  	
        [DataMember]	
        public string AddressExternalRef  { get; set; }
		  	
        [DataMember]	
        public string AddressLine3  { get; set; }
		  	
    	 public AddressUpdate()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Address.Models.AddressUpdate";
        }	
	}
}

