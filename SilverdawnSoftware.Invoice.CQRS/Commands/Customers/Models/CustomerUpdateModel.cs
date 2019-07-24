// ALLOWOVERWRITE-5A0E117844753AA2C016587829213C04

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
        /// <summary>  </summary>				
        [DataMember]	
        public int CustomerId  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public string Name  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public string PhoneNumber  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public string EmalAddress  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public bool Active  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public bool IsCompany  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public string CustomerExteranlRef  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public string TaxNo  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public IAddressView Address { get; set; }						
    	 public CustomerUpdate()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Customer.Models.CustomerUpdate";
        }	
	}
}

