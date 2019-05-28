// ALLOWOVERWRITE-E6D10A5F14F134637F5605837D4E2A59

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Invoice.Models 
{
    public partial class GetAllOverdueInvoicesForCustomer : CQRSBase,IGetAllOverdueInvoicesForCustomer
    { 
        [DataMember]
        public int CustomerId  { get; set; }
		  	
        [DataMember]
        public DateTime DueDate  { get; set; }
		  	
        [DataMember]
        public double PaidAmount  { get; set; }
		  	
    	 public GetAllOverdueInvoicesForCustomer()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Invoice.GetAllOverdueInvoicesForCustomer";
        }	
	}
}

