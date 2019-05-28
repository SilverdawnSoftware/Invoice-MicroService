// ALLOWOVERWRITE-63D6B0F1F37798D0EC0587C24BE5FF13

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Results.Models 
{
    public partial class EntityView : CQRSBase,IEntityView
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
		  	
    	 public EntityView()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Results.EntityView";
        }	
	}
}

