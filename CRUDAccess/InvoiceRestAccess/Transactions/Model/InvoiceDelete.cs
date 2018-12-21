// ALLOWOVERWRITE-8C2B24DCB6EA86A1189851CD6F416796

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;


namespace Database.Transactions.Model
{
	[DataContract]
    public class InvoiceDelete
    {
    	
    	
    	/// <summary>
        /// 
        /// </summary>
		 [DataMember(Name = "invoiceId")]         
    	public int  InvoiceId  { get; set; } 
    	
    }
}