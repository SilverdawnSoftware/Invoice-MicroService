// ALLOWOVERWRITE-F514922F545C33B128BF6EC8B70578D2-080145A0165C1D6957CE69C4AD14A449

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database
{
    public enum InvoiceStatus
    {
New= 0
    		,
Sent= 1
    		,
PaidInFull= 2
    		,
PartialPayment= 3
    		,
Cancelled = 4
    		,    	
    }
    
    
}
