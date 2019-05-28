// ALLOWOVERWRITE-DAD7280C1876ADCF8F0968284DF36E9B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Address.Models
{
    public partial interface IAddressDelete : ICQRSBase
    { 
		 int AddressId  { get; set; }
		
	}
}

