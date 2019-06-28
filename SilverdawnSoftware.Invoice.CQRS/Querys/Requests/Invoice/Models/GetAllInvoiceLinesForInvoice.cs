// ALLOWOVERWRITE-F89915141375A07D9C561509ADE7F3CB-09C665C831C732F796C35F005F695C2E

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Invoice.Models 
{
    public partial class GetAllInvoiceLinesForInvoice : CQRSBase,IGetAllInvoiceLinesForInvoice
    { 
        [DataMember]
        public int InvoiceNo  { get; set; }
		  	
    	 public GetAllInvoiceLinesForInvoice()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Invoice.GetAllInvoiceLinesForInvoice";
        }	
	}
}

