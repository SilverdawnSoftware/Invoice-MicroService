// ALLOWOVERWRITE-3B6178F78816CB58D5DF772FB6A1760B-89A27FF49EBA888DEAF378774B654BBF

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

	
    public partial class CustomerAPIController : Controller
    {
    
        /// <summary>
        /// Get All Objects for Customer
        /// </summary>	
        [Route("api/Customer/All")]
        [HttpGet]
        public async Task<List<viewModel.CustomerView>> All()
        {
            var views = new views.CustomerViews();
            return await views.GetAll();
        }
    
      
    	 /// <summary>
        /// Get Customer By CustomerId
        /// </summary>	
    	//Get Customer View Model
    	[Route("api/Customer/{customerId}")]
    	[HttpGet]
        public async Task<viewModel.CustomerView> Get([FromRoute]int customerId)
        {
            var view=new views.CustomerViews();            
            return await view.Get(customerId);            
        }
    
        
    	 /// <summary>
        /// Add New Customer
        /// </summary>	
    
    	//Add New Customer
    	[Route("api/Customer")]
    	[HttpPost]
        public async Task<viewModel.CustomerView> Add([FromBody]transModel.CustomerAdd add)
        {
            var addTrans=new trans.CustomerTransactions(); 
            var result=await addTrans.Add(add);
            return (viewModel.CustomerView) result;
        }
        
      
         /// <summary>
        /// Update Customer By CustomerId
        /// </summary>	
       
        
        //Update  Customer
    	[Route("api/Customer/{customerId}")]
    	[HttpPut]
        public async Task<viewModel.CustomerView> Update([FromRoute]int customerId,[FromBody]transModel.CustomerUpdate update)
        {
        	update.CustomerId = customerId;
            var updateTrans=new trans.CustomerTransactions();
            var result=await updateTrans.Update(update);
            return (viewModel.CustomerView) result;
                     
        }
        
         /// <summary>
        /// Delete Customer By CustomerId
        /// </summary>
         //Delete  Customer
    	[Route("api/Customer/{customerId}")]
    	[HttpDelete]
        public async Task Delete([FromRoute]int customerId)
        {
            var deleteTrans=new trans.CustomerTransactions();
			var  customerDelete=new transModel.CustomerDelete(){CustomerId=customerId };			
            await deleteTrans.Delete(customerDelete);            
        }
        
        
        
		
		 /// <summary>
        /// Find all Customers for Entity
        /// </summary>
		
		[Route("api/Entity/{EntityId}/Customers")]
    	 [HttpGet]
        public async Task<List<viewModel.CustomerView>> GetCustomersForEntity([FromRoute]int entityId)		
    	{
    		 var view=new views.CustomerViews();            
            return await view.GetCustomersForEntity(entityId); 
    	
    	}
    	
		    	
        
    }
}


