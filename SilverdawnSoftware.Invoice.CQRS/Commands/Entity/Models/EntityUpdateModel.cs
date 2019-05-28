// ALLOWOVERWRITE-634AAE76FE351B5BF6A7F609BBFA3105

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models
{
    public partial class EntityUpdate : CQRSBase, IEntityUpdate
    { 
        [DataMember]	
        public int EntityId  { get; set; }
		  	
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
		  	
    	 public EntityUpdate()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Commands.Entity.Models.EntityUpdate";
        }	
	}
}

