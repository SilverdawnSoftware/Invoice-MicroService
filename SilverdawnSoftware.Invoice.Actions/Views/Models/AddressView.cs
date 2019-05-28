// ALLOWOVERWRITE-F719A1DDDB275F7BACD4BD058114A6B8


using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace SilverdawnSoftware.Invoice.CQRS.Querys.Models.Models 
{
	[DataContract]
    public partial class AddressView : CQRSBase
    {    
		[DataMember]
		public int AddressId  { get; set; } 
		
		[DataMember]
		public string AddressLine1  { get; set; } 
		
		[DataMember]
		public string AddresLine2  { get; set; } 
		
		[DataMember]
		public string City  { get; set; } 
		
		[DataMember]
		public string PostZipCode  { get; set; } 
		
		[DataMember]
		public string StateCounty  { get; set; } 
		
		[DataMember]
		public string Country  { get; set; } 
		
		[DataMember]
		public string AddressExternalRef  { get; set; } 
		
		[DataMember]
		public string AddressLine3  { get; set; } 
		
    	
   	
    	 public AddressView()
        {
            this.__CQRSCommandName = "SilverdawnSoftware.Invoice.CQRS.Querys.Models.AddressView";
        }
    }
}
