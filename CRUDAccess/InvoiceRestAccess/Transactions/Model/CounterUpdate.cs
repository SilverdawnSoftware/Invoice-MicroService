// ALLOWOVERWRITE-64DA1426C00C3EABAA929395459CDA82-042037780A82DE1C51F6C74E4D568F29

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;

namespace Database.Transactions.Model
{
	[DataContract]
    public class CounterUpdate
    {
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "name")]                 
	    		public string Name { get; set; } 
	    		/// <summary>
                /// 
                /// </summary>
				 [DataMember(Name = "value")]                 
	    		public int Value { get; set; } 
    }
}


