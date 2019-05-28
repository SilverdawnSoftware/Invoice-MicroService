// ALLOWOVERWRITE-C09CEFDB3928EE3A2503A4D5835A3DDD

using System;
using System.Collections.Generic;
using System.Linq;



namespace SilverdawnSoftware.Invoice.Database.Views.Model
{

    public class CounterView
    {
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public string  Name  { get; set; } 	    	
	    	
	    	
	    	/// <summary>
            /// 
            /// </summary>	
	    	public int  Value  { get; set; } 	    	
    	    	
    	
    	
	    	public static explicit operator CounterView(Counter item)
	    	{
	    		var result=new CounterView();
	    	 
		    	result.Name = item.Name;     
		    	result.Value = item.Value;     
	    	
	    	
    	
    			return result;
    	}   
   
    }
}



