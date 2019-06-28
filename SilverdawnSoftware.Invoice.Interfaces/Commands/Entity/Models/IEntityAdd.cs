// ALLOWOVERWRITE-7B5506B5E11D306525C7BAD3D91212E4-045416E2757BB333EDDD51E2D0D3D470

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;
namespace SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Entity.Models
{
    public partial interface IEntityAdd : ICQRSBase
    { 

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


