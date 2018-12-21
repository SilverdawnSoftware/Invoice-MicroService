// ALLOWOVERWRITE-38548FCEEB8899D5CB7DCB7D9605BD70

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Transactions.Model
{
	[DataContract]
    public class AddressDelete
    {
    	
    	
    	/// <summary>
        /// 
        /// </summary>
		 [DataMember(Name = "addressId")]         
    	public int  AddressId  { get; set; } 
    	
    }
}