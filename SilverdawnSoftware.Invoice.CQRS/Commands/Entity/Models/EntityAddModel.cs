// ALLOWOVERWRITE-6E06BE9D532FE198EBEBC5C40F947845

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models
{
    public partial class EntityAdd : CQRSBase, IEntityAdd
    { 
        [DataMember]	
        public string Name  { get; set; }
		  	
        [DataMember]	
        public string EntityExternalRef  { get; set; }
		  	
        [DataMember]	
        /// To avoid Many to Many Relationships, use primary key https://github.com/aspnet/EntityFrameworkCore/issues/1368
        /// <summary>
        /// 
        /// </summary>	
        //public virtual Address Address <text> { get; set; }  				
          public int AddressAddressId  { get; set; }		
        [DataMember]	
        public string LogoURL  { get; set; }
		  	
    	 public EntityAdd()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models.EntityAdd";
        }	
	}
}

