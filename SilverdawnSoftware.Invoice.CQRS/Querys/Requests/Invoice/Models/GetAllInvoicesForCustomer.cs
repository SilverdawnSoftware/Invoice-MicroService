// ALLOWOVERWRITE-467A15591F7223DD8702A5D2610FA4E4-6C8607E1B06E9946C268D86B7DD2B55A

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Invoice.Models 
{
    public partial class GetAllInvoicesForCustomer : CQRSBase,IGetAllInvoicesForCustomer
    { 
        [DataMember]
        public int CustomerId  { get; set; }
		  	
    	 public GetAllInvoicesForCustomer()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Invoice.GetAllInvoicesForCustomer";
        }	
	}
}

