// ALLOWOVERWRITE-8BA29600A55C634A67F3CB6663F162DE
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using System.Runtime.Serialization;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice.Models;
using SilverdawnSoftware.Invoice.Interfaces;


namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice
{
  	public partial class InvoiceUpdateTotalsCommand : Orleans.Grain , IInvoiceUpdateTotalsCommand
    {


        /// <summary>  </summary>
        /// <param name="invoiceAdd">this is a test</param>
        /// <returns></returns>
        /// <remarks>
        /// ///

        /// </remarks>
	}



}
