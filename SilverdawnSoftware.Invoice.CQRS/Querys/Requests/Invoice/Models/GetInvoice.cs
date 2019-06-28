// ALLOWOVERWRITE-5B74ACD754D0953B0076BB051E99DC1E-596126E421B93ED3EA7B46059F686203

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Invoice.Models 
{
    public partial class GetInvoice : CQRSBase,IGetInvoice
    { 
        [DataMember]
        public int InvoiceNo  { get; set; }
		  	
    	 public GetInvoice()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Invoice.GetInvoice";
        }	
	}
}

