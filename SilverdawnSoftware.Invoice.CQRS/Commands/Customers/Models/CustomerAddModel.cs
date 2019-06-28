// ALLOWOVERWRITE-ECD860763FFCF56EADBA0D876A5EBE68-BCD37D24DFE9CB88A8F68059AAEE011B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customer.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Customer.Models
{
    public partial class CustomerAdd : CQRSBase, ICustomerAdd
    { 
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
        public int EntityId  { get; set; }
		  	
        [DataMember]	
        public IAddressView Address { get; set; }						
    	 public CustomerAdd()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Customer.Models.CustomerAdd";
        }	
	}
}

