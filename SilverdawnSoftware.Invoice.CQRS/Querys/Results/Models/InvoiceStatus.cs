// ALLOWOVERWRITE-36A97EC6AA7EDD9E69CE156AF93A4F39

using System;
using System.Collections.Generic;
using System.Linq;
namespace SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models 
{
    public enum InvoiceStatus
    {
    		New,
    		Sent,
    		PaidInFull,
    		PartialPayment,
    		Cancelled,
    		Finalized,
    }
}

