// ALLOWOVERWRITE-98D5C8136829D756D0D3E7DAF1F84BC7

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Entity.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Entity.Models 
{
    public partial class GetAllEntitys : CQRSBase,IGetAllEntitys
    { 
    	 public GetAllEntitys()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Entity.GetAllEntitys";
        }	
	}
}

