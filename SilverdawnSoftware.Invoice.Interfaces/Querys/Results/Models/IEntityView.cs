// ALLOWOVERWRITE-B7C8CE410494256A35836ACE1103A3D3

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models 
{
    public partial interface IEntityView : ICQRSBase
    { 
         int EntityId  { get; set; }
		  	
         string Name  { get; set; }
		  	
         string EntityExternalRef  { get; set; }
		  	
        /// To avoid Many to Many Relationships, use primary key https://github.com/aspnet/EntityFrameworkCore/issues/1368
        /// <summary>
        /// 
        /// </summary>	
        //public virtual Address Address <text> { get; set; }  				
         int AddressAddressId  { get; set; }		
         string LogoURL  { get; set; }
		  	
	}
}



