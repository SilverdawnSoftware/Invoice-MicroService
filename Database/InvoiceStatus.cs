// ALLOWOVERWRITE-C70A9AA231905E24CC0592A29F9C771D

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
Finalized    		,
    	
    }
    
    
}
