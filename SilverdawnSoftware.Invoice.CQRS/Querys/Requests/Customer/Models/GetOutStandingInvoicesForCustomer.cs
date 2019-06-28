// ALLOWOVERWRITE-B2687322639B963C7D39C29506A517DB-F7242674D8CD4249A893E6592B771A65

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Customer.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Customer.Models 
{
    public partial class GetOutStandingInvoicesForCustomer : CQRSBase,IGetOutStandingInvoicesForCustomer
    { 
        [DataMember]
        public int CustomerId  { get; set; }
		  	
        [DataMember]
        public double PaidAmount  { get; set; }
		  	
    	 public GetOutStandingInvoicesForCustomer()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Customer.GetOutStandingInvoicesForCustomer";
        }	
	}
}

