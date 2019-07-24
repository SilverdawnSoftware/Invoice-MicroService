// ALLOWOVERWRITE-497CF2D5B5A51DB5CAA2042367F1AE7A

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
        public int EntityId  { get; set; }
		  	
        /// <summary>  </summary>				
        [DataMember]	
        public IAddressView Address { get; set; }						
    	 public CustomerAdd()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Customer.Models.CustomerAdd";
        }	
	}
}

