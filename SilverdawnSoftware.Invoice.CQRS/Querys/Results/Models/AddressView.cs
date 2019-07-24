// ALLOWOVERWRITE-58E9AC5E46502B0FF163FEB3B3A377F0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models 
{
    public partial class AddressView : CQRSBase,IAddressView
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
		  	
    	 public AddressView()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Results.AddressView";
        }	
	}
}

