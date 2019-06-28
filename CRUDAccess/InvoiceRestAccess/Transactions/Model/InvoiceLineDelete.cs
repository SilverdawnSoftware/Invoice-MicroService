// ALLOWOVERWRITE-F1910482EC8F72FC4827E58B5CDE5FA0-439763C09A5C6160D9CB907F6B967764

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Transactions.Model
{
	[DataContract]
    public class InvoiceLineDelete
    {
    	
    	
    	/// <summary>
        /// 
        /// </summary>
		 [DataMember(Name = "invoiceLineId")]         
    	public int  InvoiceLineId  { get; set; } 
    	
    }
}
