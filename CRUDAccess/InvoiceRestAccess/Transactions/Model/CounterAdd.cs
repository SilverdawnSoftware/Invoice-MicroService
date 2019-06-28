// ALLOWOVERWRITE-3F6C126FC24087C8876E6149D44A2355-0790569F8D9C1A14933B9F4AAA620542

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
namespace Database.Transactions.Model
{
	[DataContract]
    public class CounterAdd
    {
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "name")]                
	    		public string Name  { get; set; } 
	    		 /// <summary>
                  /// 
                  /// </summary>
				[DataMember(Name = "value")]                
	    		public int Value  { get; set; } 
    }    	    	
}




