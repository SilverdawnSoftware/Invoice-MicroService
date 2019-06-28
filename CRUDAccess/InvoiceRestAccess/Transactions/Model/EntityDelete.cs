// ALLOWOVERWRITE-9AF177F2FFC7CECC0AC2C64F61B2E2AA-69DCAB737C91D48F15BAFE4DF45BFE72

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Transactions.Model
{
	[DataContract]
    public class EntityDelete
    {
    	
    	
    	/// <summary>
        /// 
        /// </summary>
		 [DataMember(Name = "entityId")]         
    	public int  EntityId  { get; set; } 
    	
    }
}
