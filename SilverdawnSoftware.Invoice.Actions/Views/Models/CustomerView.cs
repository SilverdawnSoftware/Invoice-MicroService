// ALLOWOVERWRITE-2A7323D8AB98334BC92BBD1CF3BDC9F0


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SilverdawnSoftware.Invoice.CQRS.Querys.Models.Models 
{
	[DataContract]
    public partial class CustomerView : CQRSBase
    {    
		[DataMember]
		public int CustomerId  { get; set; } 
		
		[DataMember]
		public string Name  { get; set; } 
		
		[DataMember]
		public string PhoneNumber  { get; set; } 
		
		[DataMember]
		public string EmalAddress  { get; set; } 
		
		[DataMember]
		public bool Active  { get; set; } 
		
		[DataMember]
		public bool IsCompany  { get; set; } 
		
		[DataMember]
		public string CustomerExteranlRef  { get; set; } 
		
		[DataMember]
		public string TaxNo  { get; set; } 
		
    	
   	
    	 public CustomerView()
        {
            this.__CQRSCommandName = "SilverdawnSoftware.Invoice.CQRS.Querys.Models.CustomerView";
        }
    }
}
