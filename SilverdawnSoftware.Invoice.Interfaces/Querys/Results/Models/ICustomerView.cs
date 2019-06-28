// ALLOWOVERWRITE-48470C88E7E29FE68084254DFE0B12D9-B0BCED5B19847B36A74DB36946EBB4DF

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models 
{
    public partial interface ICustomerView : ICQRSBase
    { 
		
        int CustomerId  { get; set; }	
		
        string Name  { get; set; }	
		
        string PhoneNumber  { get; set; }	
		
        string EmalAddress  { get; set; }	
		
        bool Active  { get; set; }	
		
        bool IsCompany  { get; set; }	
		
        string CustomerExteranlRef  { get; set; }	
		
        string TaxNo  { get; set; }	
		
        int EntityId  { get; set; }	
	}
}



