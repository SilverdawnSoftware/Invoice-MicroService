// ALLOWOVERWRITE-92A66B0F10C266ADB5B715AB30E38020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models 
{
    public partial class CustomerView : CQRSBase,ICustomerView
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
        public int EntityId  { get; set; }
		  	
    	 public CustomerView()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Results.CustomerView";
        }	
	}
}

