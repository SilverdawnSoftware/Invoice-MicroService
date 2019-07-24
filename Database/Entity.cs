// ALLOWOVERWRITE-B9EEE965674BB026931176773C282913

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SilverdawnSoftware.Invoice.Database
{
	
    public class Entity 
    {

        /// <summary>  </summary>
        [Key]			
        public int EntityId { get; set; }     	

        /// <summary>  </summary>
        public string Name { get; set; }     	

        /// <summary>  </summary>
        public string EntityExternalRef { get; set; }     	

        /// <summary>  </summary>	
        public virtual Address  Address   { get; set; }

        /// <summary>  </summary>
        public string LogoURL { get; set; }     	

        /// <summary>  </summary>
        public string SMTPEmailFromAddress { get; set; }     	

        /// <summary>  </summary>
        public string SMTPUserName { get; set; }     	

        /// <summary>  </summary>
        public string SMTPPassword { get; set; }     	

        /// <summary>  </summary>
        public string SMTPHost { get; set; }     	

        /// <summary>  </summary>
        public string SMTPEmailDisplayName { get; set; }     	
    	/// <summary>
        /// List of Customers
        /// </summary>	
    	public virtual List<Customer> Customers { get; set; }
    }
}

























