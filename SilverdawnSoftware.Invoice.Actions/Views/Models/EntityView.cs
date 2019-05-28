// ALLOWOVERWRITE-DA488E3FF4D3CC98BBD632D6FFF45C45


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SilverdawnSoftware.Invoice.CQRS.Querys.Models.Models 
{
	[DataContract]
    public partial class EntityView : CQRSBase
    {    
		[DataMember]
		public int EntityId  { get; set; } 
		
		[DataMember]
		public string Name  { get; set; } 
		
		[DataMember]
		public string EntityExternalRef  { get; set; } 
		
		[DataMember]
		public Address Address  { get; set; } 
		
		[DataMember]
		public string LogoURL  { get; set; } 
		
    	
   	
    	 public EntityView()
        {
            this.__CQRSCommandName = "SilverdawnSoftware.Invoice.CQRS.Querys.Models.EntityView";
        }
    }
}
