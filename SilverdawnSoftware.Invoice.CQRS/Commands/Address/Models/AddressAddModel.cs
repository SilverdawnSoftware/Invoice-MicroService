// ALLOWOVERWRITE-DEEE0C25CBCEE04CBAAD1EDA3A5E4D6C

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Address.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Address.Models
{
    public partial class AddressAdd : CQRSBase, IAddressAdd
    { 
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
		  	
        [DataMember]	
        public int CustomerId  { get; set; }
		  	
    	 public AddressAdd()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Address.Models.AddressAdd";
        }	
	}
}

