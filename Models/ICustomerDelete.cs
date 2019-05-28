// ALLOWOVERWRITE-A21FB6065EB6BB85862FE0EF1FC7DC52

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customers.Models
{
    public partial interface ICustomerDelete : ICQRSBase
    { 
         int CustomerId  { get; set; }
		  	
	}
}

