// ALLOWOVERWRITE-BDAACC39DF73EC48870478BB8F559172

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Address.Models 
{
    public partial interface IGetAddress : ICQRSBase
    { 
         int AddressId  { get; set; }
		  	
	}
}



