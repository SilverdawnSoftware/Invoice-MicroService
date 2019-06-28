// ALLOWOVERWRITE-7CBD3FAA8D078AA96D6E8D2B7B9F916C-47237147E110227D7E1751556F5CE134
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

		
	}



}
