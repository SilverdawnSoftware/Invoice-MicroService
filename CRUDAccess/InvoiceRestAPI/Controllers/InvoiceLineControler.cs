// ALLOWOVERWRITE-BDE89D027EB744A1BA4D0751308C1026

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

	
    public partial class InvoiceLineAPIController : Controller
    {
    
        /// <summary>
        /// Get All Objects for InvoiceLine
        /// </summary>	
        [Route("api/InvoiceLine/All")]
        [HttpGet]
        public async Task<List<viewModel.InvoiceLineView>> All()
        {
            var views = new views.InvoiceLineViews();
            return await views.GetAll();
        }
    
      
    	 /// <summary>
        /// Get InvoiceLine By InvoiceLineId
        /// </summary>	
    	//Get InvoiceLine View Model
    	[Route("api/InvoiceLine/{invoiceLineId}")]
    	[HttpGet]
        public async Task<viewModel.InvoiceLineView> Get([FromRoute]int invoiceLineId)
        {
            var view=new views.InvoiceLineViews();            
            return await view.Get(invoiceLineId);            
        }
    
        
    	 /// <summary>
        /// Add New InvoiceLine
        /// </summary>	
    
    	//Add New InvoiceLine
    	[Route("api/InvoiceLine")]
    	[HttpPost]
        public async Task<viewModel.InvoiceLineView> Add([FromBody]transModel.InvoiceLineAdd add)
        {
            var addTrans=new trans.InvoiceLineTransactions(); 
            var result=await addTrans.Add(add);
            return (viewModel.InvoiceLineView) result;
        }
        
      
         /// <summary>
        /// Update InvoiceLine By InvoiceLineId
        /// </summary>	
       
        
        //Update  InvoiceLine
    	[Route("api/InvoiceLine/{invoiceLineId}")]
    	[HttpPut]
        public async Task<viewModel.InvoiceLineView> Update([FromRoute]int invoiceLineId,[FromBody]transModel.InvoiceLineUpdate update)
        {
        	update.InvoiceLineId = invoiceLineId;
            var updateTrans=new trans.InvoiceLineTransactions();
            var result=await updateTrans.Update(update);
            return (viewModel.InvoiceLineView) result;
                     
        }
        
         /// <summary>
        /// Delete InvoiceLine By InvoiceLineId
        /// </summary>
         //Delete  InvoiceLine
    	[Route("api/InvoiceLine/{invoiceLineId}")]
    	[HttpDelete]
        public async Task Delete([FromRoute]int invoiceLineId)
        {
            var deleteTrans=new trans.InvoiceLineTransactions();
			var  invoiceLineDelete=new transModel.InvoiceLineDelete(){InvoiceLineId=invoiceLineId };			
            await deleteTrans.Delete(invoiceLineDelete);            
        }
        
        
        
		
		 /// <summary>
        /// Find all InvoiceLines for Invoice
        /// </summary>
		
		[Route("api/Invoice/{InvoiceId}/InvoiceLines")]
    	 [HttpGet]
        public async Task<List<viewModel.InvoiceLineView>> GetInvoiceLinesForInvoice([FromRoute]int invoiceId)		
    	{
    		 var view=new views.InvoiceLineViews();            
            return await view.GetInvoiceLinesForInvoice(invoiceId); 
    	
    	}
    	
		    	
        
    }
}


