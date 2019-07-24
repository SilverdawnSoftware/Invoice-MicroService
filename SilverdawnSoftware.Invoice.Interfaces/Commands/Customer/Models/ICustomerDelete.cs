// ALLOWOVERWRITE-35EBF86D14CC35915F6038957E83DF8D

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Customer.Models
{
    public partial interface ICustomerDelete : ICQRSBase
    { 
         int CustomerId  { get; set; }
		  	
	}
}

