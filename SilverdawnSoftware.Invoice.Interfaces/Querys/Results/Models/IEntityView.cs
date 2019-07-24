// ALLOWOVERWRITE-26288F1F9005230F489A67BDF173BDC9

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models 
{
    public partial interface IEntityView : ICQRSBase
    { 
        int EntityId  { get; set; }	
        string Name  { get; set; }	
        string EntityExternalRef  { get; set; }	
         IAddressView  Address   { get; set; }					
        string LogoURL  { get; set; }	
        string SMTPEmailFromAddress  { get; set; }	
        string SMTPUserName  { get; set; }	
        string SMTPPassword  { get; set; }	
        string SMTPHost  { get; set; }	
        string SMTPEmailDisplayName  { get; set; }	
	}
}



