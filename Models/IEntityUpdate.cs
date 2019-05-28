// ALLOWOVERWRITE-EBCFBF3E97C6884FB36A11D57BCEDAD1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity.Models
{
    public partial interface IEntityUpdate : ICQRSBase
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

