// ALLOWOVERWRITE-5BF450A5551659875A9E8248FB7C9374

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Requests.Entity.Models;

namespace SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Entity.Models 
{
    public partial class SearchEntityByName : CQRSBase,ISearchEntityByName
    { 
        [DataMember]
        public string Name  { get; set; }
		  	
    	 public SearchEntityByName()
        {
            this.__CQRSModel = "SilverdawnSoftware.Invoice.CQRS.Querys.Requests.Entity.SearchEntityByName";
        }	
	}
}

