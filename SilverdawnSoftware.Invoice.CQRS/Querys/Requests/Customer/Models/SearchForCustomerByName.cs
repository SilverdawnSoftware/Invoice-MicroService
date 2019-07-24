// ALLOWOVERWRITE-C2FE1FEFB7AF442ED8B0A524B9581E15

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Customer.Models 
{
    public partial class SearchForCustomerByName : CQRSBase,ISearchForCustomerByName
    { 
        [DataMember]
        public string Name  { get; set; }
		  	
    	 public SearchForCustomerByName()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Customer.SearchForCustomerByName";
        }	
	}
}

