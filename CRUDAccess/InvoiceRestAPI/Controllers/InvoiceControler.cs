// ALLOWOVERWRITE-F16836DA3E8E98DF663A37B4BE1AAA4E

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

	
    public partial class InvoiceAPIController : Controller
    {
    
        /// <summary>
        /// Get All Objects for Invoice
        /// </summary>	
        [Route("api/Invoice/All")]
        [HttpGet]
        public async Task<List<viewModel.InvoiceView>> All()
        {
            var views = new views.InvoiceViews();
            return await views.GetAll();
        }
    
      
    	 /// <summary>
        /// Get Invoice By InvoiceId
        /// </summary>	
    	//Get Invoice View Model
    	[Route("api/Invoice/{invoiceId}")]
    	[HttpGet]
        public async Task<viewModel.InvoiceView> Get([FromRoute]int invoiceId)
        {
            var view=new views.InvoiceViews();            
            return await view.Get(invoiceId);            
        }
    
        
    	 /// <summary>
        /// Add New Invoice
        /// </summary>	
    
    	//Add New Invoice
    	[Route("api/Invoice")]
    	[HttpPost]
        public async Task<viewModel.InvoiceView> Add([FromBody]transModel.InvoiceAdd add)
        {
            var addTrans=new trans.InvoiceTransactions(); 
            var result=await addTrans.Add(add);
            return (viewModel.InvoiceView) result;
        }
        
      
         /// <summary>
        /// Update Invoice By InvoiceId
        /// </summary>	
       
        
        //Update  Invoice
    	[Route("api/Invoice/{invoiceId}")]
    	[HttpPut]
        public async Task<viewModel.InvoiceView> Update([FromRoute]int invoiceId,[FromBody]transModel.InvoiceUpdate update)
        {
        	update.InvoiceId = invoiceId;
            var updateTrans=new trans.InvoiceTransactions();
            var result=await updateTrans.Update(update);
            return (viewModel.InvoiceView) result;
                     
        }
        
         /// <summary>
        /// Delete Invoice By InvoiceId
        /// </summary>
         //Delete  Invoice
    	[Route("api/Invoice/{invoiceId}")]
    	[HttpDelete]
        public async Task Delete([FromRoute]int invoiceId)
        {
            var deleteTrans=new trans.InvoiceTransactions();
			var  invoiceDelete=new transModel.InvoiceDelete(){InvoiceId=invoiceId };			
            await deleteTrans.Delete(invoiceDelete);            
        }
        
        
        
		
		 /// <summary>
        /// Find all Invoices for Customer
        /// </summary>
		
		[Route("api/Customer/{CustomerId}/Invoices")]
    	 [HttpGet]
        public async Task<List<viewModel.InvoiceView>> GetInvoicesForCustomer([FromRoute]int customerId)		
    	{
    		 var view=new views.InvoiceViews();            
            return await view.GetInvoicesForCustomer(customerId); 
    	
    	}
    	
		    	
        
    }
}


