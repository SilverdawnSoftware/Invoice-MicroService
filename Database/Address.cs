// ALLOWOVERWRITE-F6A453E77EFAB7C13E8F47F79260D9AA

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SilverdawnSoftware.Invoice.Database
{
	
    [Owned]
    public class Address 
    {

        /// <summary>  </summary>
        public string AddressLine1 { get; set; }     	

        /// <summary>  </summary>
        public string AddresLine2 { get; set; }     	

        /// <summary>  </summary>
        public string City { get; set; }     	

        /// <summary>  </summary>
        public string PostZipCode { get; set; }     	

        /// <summary>  </summary>
        public string StateCounty { get; set; }     	

        /// <summary>  </summary>
        public string Country { get; set; }     	

        /// <summary>  </summary>
        public string AddressExternalRef { get; set; }     	

        /// <summary>  </summary>
        public string AddressLine3 { get; set; }     	
    }
}

























