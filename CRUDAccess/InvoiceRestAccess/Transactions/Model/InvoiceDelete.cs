// ALLOWOVERWRITE-5CA428B2E13A46EEBBC816D337A6DFA3-D7596E9E1B6E0D8E89BAA708A8E8B8AF

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
        /// Primary Key for Invoices
        /// </summary>
		 [DataMember(Name = "invoiceId")]         
    	public int  InvoiceId  { get; set; } 
    	
    }
}
