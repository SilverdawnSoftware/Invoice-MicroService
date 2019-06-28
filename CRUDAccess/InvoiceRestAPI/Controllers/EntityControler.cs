// ALLOWOVERWRITE-2B29532E93DCBCE675C3C04C3B6D0DFE-C5D91A0F0CAE7BDD9EA29B6456ABD54B

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

	
    public partial class EntityAPIController : Controller
    {
    
        /// <summary>
        /// Get All Objects for Entity
        /// </summary>	
        [Route("api/Entity/All")]
        [HttpGet]
        public async Task<List<viewModel.EntityView>> All()
        {
            var views = new views.EntityViews();
            return await views.GetAll();
        }
    
      
    	 /// <summary>
        /// Get Entity By EntityId
        /// </summary>	
    	//Get Entity View Model
    	[Route("api/Entity/{entityId}")]
    	[HttpGet]
        public async Task<viewModel.EntityView> Get([FromRoute]int entityId)
        {
            var view=new views.EntityViews();            
            return await view.Get(entityId);            
        }
    
        
    	 /// <summary>
        /// Add New Entity
        /// </summary>	
    
    	//Add New Entity
    	[Route("api/Entity")]
    	[HttpPost]
        public async Task<viewModel.EntityView> Add([FromBody]transModel.EntityAdd add)
        {
            var addTrans=new trans.EntityTransactions(); 
            var result=await addTrans.Add(add);
            return (viewModel.EntityView) result;
        }
        
      
         /// <summary>
        /// Update Entity By EntityId
        /// </summary>	
       
        
        //Update  Entity
    	[Route("api/Entity/{entityId}")]
    	[HttpPut]
        public async Task<viewModel.EntityView> Update([FromRoute]int entityId,[FromBody]transModel.EntityUpdate update)
        {
        	update.EntityId = entityId;
            var updateTrans=new trans.EntityTransactions();
            var result=await updateTrans.Update(update);
            return (viewModel.EntityView) result;
                     
        }
        
         /// <summary>
        /// Delete Entity By EntityId
        /// </summary>
         //Delete  Entity
    	[Route("api/Entity/{entityId}")]
    	[HttpDelete]
        public async Task Delete([FromRoute]int entityId)
        {
            var deleteTrans=new trans.EntityTransactions();
			var  entityDelete=new transModel.EntityDelete(){EntityId=entityId };			
            await deleteTrans.Delete(entityDelete);            
        }
        
        
        
        
    }
}


