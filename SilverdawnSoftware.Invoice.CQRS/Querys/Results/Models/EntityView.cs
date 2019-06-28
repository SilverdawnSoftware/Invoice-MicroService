// ALLOWOVERWRITE-37C626D1DB322B18C0ABAA0CF3B7FE1D-E160875351EF1138889DBC28F39346D4

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
        public IAddressView Address { get; set; } =new AddressView();						

        [DataMember]
        public string LogoURL  { get; set; }

        [DataMember]
        public string SMTPEmailFromAddress  { get; set; }

        [DataMember]
        public string SMTPUserName  { get; set; }

        [DataMember]
        public string SMTPPassword  { get; set; }

        [DataMember]
        public string SMTPHost  { get; set; }

        [DataMember]
        public string SMTPEmailDisplayName  { get; set; }
    	
    	 public EntityView()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Results.EntityView";
        }	
	}
}

