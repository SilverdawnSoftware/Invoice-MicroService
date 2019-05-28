using System;
using System.Collections.Generic;
using System.Text;
using SilverdawnSoftware.Invoice.Interfaces;

namespace SilverdawnSoftware.Invoice.CQRS
{
    public class CQRSBase:ICQRSBase
    {
        public bool __CQRSSuccessful { get; set; } = true;
        public string __CQRSErrorMessage { get; set; } = "";
        public string __CQRSModel { get; set; }
        public int __CQRSStatusCode { get; set; } = 200;

    }
}
