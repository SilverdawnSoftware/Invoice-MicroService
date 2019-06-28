// ALLOWOVERWRITE-331BC7907B5D692A5E4B9240FDB52DC5-11FC8F1277458CC6A5E13CA03A083921

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity.Models
{
    public partial interface IEntityUpdate : ICQRSBase
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


