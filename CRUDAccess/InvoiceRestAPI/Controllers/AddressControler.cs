// ALLOWOVERWRITE-E4F8D2EBE8C59F117102088AD2E997BE

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

	
    public partial class AddressAPIController : Controller
    {
    
        /// <summary>
        /// Get All Objects for Address
        /// </summary>	
        [Route("api/Address/All")]
        [HttpGet]
        public async Task<List<viewModel.AddressView>> All()
        {
            var views = new views.AddressViews();
            return await views.GetAll();
        }
    
      
    	 /// <summary>
        /// Get Address By AddressId
        /// </summary>	
    	//Get Address View Model
    	[Route("api/Address/{addressId}")]
    	[HttpGet]
        public async Task<viewModel.AddressView> Get([FromRoute]int addressId)
        {
            var view=new views.AddressViews();            
            return await view.Get(addressId);            
        }
    
        
    	 /// <summary>
        /// Add New Address
        /// </summary>	
    
    	//Add New Address
    	[Route("api/Address")]
    	[HttpPost]
        public async Task<viewModel.AddressView> Add([FromBody]transModel.AddressAdd add)
        {
            var addTrans=new trans.AddressTransactions(); 
            var result=await addTrans.Add(add);
            return (viewModel.AddressView) result;
        }
        
      
         /// <summary>
        /// Update Address By AddressId
        /// </summary>	
       
        
        //Update  Address
    	[Route("api/Address/{addressId}")]
    	[HttpPut]
        public async Task<viewModel.AddressView> Update([FromRoute]int addressId,[FromBody]transModel.AddressUpdate update)
        {
        	update.AddressId = addressId;
            var updateTrans=new trans.AddressTransactions();
            var result=await updateTrans.Update(update);
            return (viewModel.AddressView) result;
                     
        }
        
         /// <summary>
        /// Delete Address By AddressId
        /// </summary>
         //Delete  Address
    	[Route("api/Address/{addressId}")]
    	[HttpDelete]
        public async Task Delete([FromRoute]int addressId)
        {
            var deleteTrans=new trans.AddressTransactions();
			var  addressDelete=new transModel.AddressDelete(){AddressId=addressId };			
            await deleteTrans.Delete(addressDelete);            
        }
        
        
        
		
		 /// <summary>
        /// Find all Addresss for Customer
        /// </summary>
		
		[Route("api/Customer/{CustomerId}/Addresss")]
    	 [HttpGet]
        public async Task<List<viewModel.AddressView>> GetAddresssForCustomer([FromRoute]int customerId)		
    	{
    		 var view=new views.AddressViews();            
            return await view.GetAddresssForCustomer(customerId); 
    	
    	}
    	
		    	
        
    }
}


