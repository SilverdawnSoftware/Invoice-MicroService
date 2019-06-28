// ALLOWOVERWRITE-F90707B6EB997814C3CEA2395654AAB8-3A310AA64069BBAA6EA32AD29E3574C2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models
{
	[DataContract]
    public partial class InvoiceDelete : CQRSBase, IInvoiceDelete
    { 
        [DataMember]	
        public int InvoiceId  { get; set; }
		  	
    	 public InvoiceDelete()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceDelete";
        }	
	}
}

