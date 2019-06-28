// ALLOWOVERWRITE-DB3F7BAC6316DA098248D6AA76C9F58B-E790FB28214316C7E19C9D2703595299

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customer.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;

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
		  	
        [DataMember]	
        public IAddressView Address { get; set; }						
    	 public CustomerUpdate()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Customer.Models.CustomerUpdate";
        }	
	}
}

