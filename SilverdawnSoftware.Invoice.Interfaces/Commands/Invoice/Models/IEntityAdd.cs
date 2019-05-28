// ALLOWOVERWRITE-D7EBE23B159270CF7EB6D2AE3B9C40A0

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity.Models
{
    public partial interface IEntityAdd : ICQRSBase
    { 
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

