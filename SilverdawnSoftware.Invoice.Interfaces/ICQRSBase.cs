namespace SilverdawnSoftware.Invoice.Interfaces
{
    public interface ICQRSBase 
    {
       
             bool __CQRSSuccessful { get; set; } 
             string __CQRSErrorMessage { get; set; } 
             string __CQRSModel { get; set; }
             int __CQRSStatusCode { get; set; } 

        
    }
}