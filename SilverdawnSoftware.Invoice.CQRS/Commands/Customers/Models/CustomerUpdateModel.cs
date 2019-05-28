// ALLOWOVERWRITE-E0B3E83C1E4F04FA2C8DAC175A9021AB

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customer.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Customer.Models
{
    public partial class CustomerUpdate : CQRSBase, ICustomerUpdate
    { 
        [DataMember]	
        public int CustomerId  { get; set; }
		  	
        [DataMember]	
        public string Name  { get; set; }
		  	
        [DataMember]	
        public string PhoneNumber  { get; set; }
		  	
        [DataMember]	
        public string EmalAddress  { get; set; }
		  	
        [DataMember]	
        public bool Active  { get; set; }
		  	
        [DataMember]	
        public bool IsCompany  { get; set; }
		  	
        [DataMember]	
        public string CustomerExteranlRef  { get; set; }
		  	
        [DataMember]	
        public string TaxNo  { get; set; }
		  	
    	 public CustomerUpdate()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Customer.Models.CustomerUpdate";
        }	
	}
}

