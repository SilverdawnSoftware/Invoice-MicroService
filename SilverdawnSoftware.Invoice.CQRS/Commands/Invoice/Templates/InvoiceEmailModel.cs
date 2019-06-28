using System;
using System.Collections.Generic;
using System.Text;

namespace SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Templates
{
    public class InvoiceEmailModel
    {
        public Database.Invoice Invoice { get; set; }

        public Database.Address EntityAddress { get; set; }

        public Database.Address BillingAddress { get; set; }

    }
}
