// ALLOWOVERWRITE-735C65F36B2BDB73A70B39C88D420BDF

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Transactions.Model
{
	[DataContract]
    public class CounterDelete
    {
    	
    	
    	/// <summary>
        /// 
        /// </summary>
		 [DataMember(Name = "name")]         
    	public string  Name  { get; set; } 
    	
    }
}
