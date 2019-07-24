// ALLOWOVERWRITE-1C31165CBC8265D8428BDF0D8471AA69

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.InvoiceLine.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.InvoiceLine.Models 
{
    public partial class GetInvoiceLine : CQRSBase,IGetInvoiceLine
    { 
        [DataMember]
        public int InvoiceLineId  { get; set; }
		  	
    	 public GetInvoiceLine()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Requests.InvoiceLine.GetInvoiceLine";
        }	
	}
}

