// ALLOWOVERWRITE-718D3572AD4C689DEDB741DB4FB47C9E

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace SilverdawnSoftware.Invoice.Database
{
	
    public class Counter 
    {

        /// <summary>  </summary>
        [Key]			
        public string Name { get; set; }     	

        /// <summary>  </summary>
        public int Value { get; set; }     	
    }
}

























