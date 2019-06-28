// ALLOWOVERWRITE-24D1DDBCF6122555841282415CFCAF37-E7614E2C8AF5661D7C6424F0F6F82160

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models
{
	[DataContract]
    public partial class InvoiceEmail : CQRSBase, IInvoiceEmail
    { 
        [DataMember]	
        public int InvoiceId  { get; set; }
		  	
    	 public InvoiceEmail()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models.InvoiceEmail";
        }	
	}
}

