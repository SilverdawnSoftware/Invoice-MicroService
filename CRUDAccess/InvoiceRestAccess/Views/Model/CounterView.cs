// ALLOWOVERWRITE-299BBA5A623FF74A211181765F2CFDCB

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Views.Model
{

	[DataContract]
    public class CounterView
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



