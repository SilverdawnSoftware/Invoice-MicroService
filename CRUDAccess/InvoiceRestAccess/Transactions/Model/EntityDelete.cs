// ALLOWOVERWRITE-69DCAB737C91D48F15BAFE4DF45BFE72

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