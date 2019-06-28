// ALLOWOVERWRITE-E431985459ABE8D9901BB64C6FEED1BA-A37D596CB0B2138BF406710F0EAA5651

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models
{
    public partial interface IInvoiceUpdateNotes : ICQRSBase
    { 

         int InvoiceId  { get; set; } 	

         string Notes  { get; set; } 	
	}
}


