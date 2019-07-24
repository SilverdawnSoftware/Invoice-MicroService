// ALLOWOVERWRITE-C31DAB1B187FDBFD6A28AE40875132B3
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using transModel =SilverdawnSoftware.Invoice.Database.Transactions.Model;
using trans =SilverdawnSoftware.Invoice.Database.Transactions;
using viewModel =SilverdawnSoftware.Invoice.Database.Views.Model;
using views =SilverdawnSoftware.Invoice.Database.Views;
namespace InvoiceRestAPI
{	
    public partial class PaymentHistoryAPIController : Controller
    {    
        /// <summary>
        /// Get All Objects for PaymentHistory
        /// </summary>	
        [Route("api/PaymentHistory/All")]
        [HttpGet]
        public async Task<List<viewModel.PaymentHistoryView>> All()
        {
           var views = new views.PaymentHistoryViews();
            return await views.GetAll();
        }
    	 /// <summary>
        /// Get PaymentHistory By PaymentHistoryId
        /// </summary>	
    	//Get PaymentHistory View Model
    	[Route("api/PaymentHistory/{paymentHistoryId}")]
    	[HttpGet]
        public async Task<viewModel.PaymentHistoryView> Get([FromRoute]int paymentHistoryId)
        {
            var view=new views.PaymentHistoryViews();            
            return await view.Get(paymentHistoryId);            
        }    
        
    	 /// <summary>
        /// Add New PaymentHistory
        /// </summary>	
    
    	//Add New PaymentHistory
    	[Route("api/PaymentHistory")]
    	[HttpPost]
        public async Task<viewModel.PaymentHistoryView> Add([FromBody]transModel.PaymentHistoryAdd add)
        {
            var addTrans=new trans.PaymentHistoryTransactions(); 
            var result=await addTrans.Add(add);
            return (viewModel.PaymentHistoryView) result;
        }
              
         /// <summary>
        /// Update PaymentHistory By PaymentHistoryId
        /// </summary>	
       
        
        //Update  PaymentHistory
    	[Route("api/PaymentHistory/{paymentHistoryId}")]
    	[HttpPut]
        public async Task<viewModel.PaymentHistoryView> Update([FromRoute]int paymentHistoryId,[FromBody]transModel.PaymentHistoryUpdate update)
        {
        	update.PaymentHistoryId = paymentHistoryId;
            var updateTrans=new trans.PaymentHistoryTransactions();
            var result=await updateTrans.Update(update);
            return (viewModel.PaymentHistoryView) result;
                     
        }
        
         /// <summary>
        /// Delete PaymentHistory By PaymentHistoryId
        /// </summary>
         //Delete  PaymentHistory
    	[Route("api/PaymentHistory/{paymentHistoryId}")]
    	[HttpDelete]
        public async Task Delete([FromRoute]int paymentHistoryId)
        {
            var deleteTrans=new trans.PaymentHistoryTransactions();
			var  paymentHistoryDelete=new transModel.PaymentHistoryDelete(){PaymentHistoryId=paymentHistoryId };			
            await deleteTrans.Delete(paymentHistoryDelete);            
        }
        
                
		 /// <summary>
        /// Find all PaymentHistorys for Invoice
        /// </summary>
		
		[Route("api/Invoice/{InvoiceId}/PaymentHistorys")]
    	 [HttpGet]
        public async Task<List<viewModel.PaymentHistoryView>> GetPaymentHistorysForInvoice([FromRoute]int invoiceId)		
    	{
    		 var view=new views.PaymentHistoryViews();            
            return await view.GetPaymentHistorysForInvoice(invoiceId); 
    	
    	}    	  	
    }
}



