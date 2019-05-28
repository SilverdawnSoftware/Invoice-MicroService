// ALLOWOVERWRITE-98CB21CC7402E305CE51E473B3B7DE2F

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using transModel =SilverdawnSoftware.Invoice.Database.Transactions.Model;
using trans =SilverdawnSoftware.Invoice.Database.Transactions;
using viewModel =SilverdawnSoftware.Invoice.Database.Views.Model;
using views =SilverdawnSoftware.Invoice.Database.Views;


namespace InvoiceRestAPI
{

	
    public partial class CounterAPIController : Controller
    {
    
        /// <summary>
        /// Get All Objects for Counter
        /// </summary>	
        [Route("api/Counter/All")]
        [HttpGet]
        public async Task<List<viewModel.CounterView>> All()
        {
            var views = new views.CounterViews();
            return await views.GetAll();
        }
    
      /*
    	 /// <summary>
        /// Get Counter By 
        /// </summary>	
    	//Get Counter View Model
    	[Route("api/Counter/{}")]
    	[HttpGet]
        public async Task<viewModel.CounterView> Get([FromRoute]string name )
        {
            var view=new views.CounterViews();            
            return await view.GetAll();            
        }*/
    
        
    	 /// <summary>
        /// Add New Counter
        /// </summary>	
    
    	//Add New Counter
    	[Route("api/Counter")]
    	[HttpPost]
        public async Task<viewModel.CounterView> Add([FromBody]transModel.CounterAdd add)
        {
            var addTrans=new trans.CounterTransactions(); 
            var result=await addTrans.Add(add);
            return (viewModel.CounterView) result;
        }
        
      
         /// <summary>
        /// Update Counter By 
        /// </summary>	
       
        /*
        //Update  Counter
    	[Route("api/Counter/{}")]
    	[HttpPut]
        public async Task<viewModel.CounterView> Update([FromRoute]string name ,[FromBody]transModel.CounterUpdate update)
        {
        	update.Name = name;
            var updateTrans=new trans.CounterTransactions();
            var result=await updateTrans.Update(update);
            return (viewModel.CounterView) result;
                     
        }
        
         /// <summary>
        /// Delete Counter By 
        /// </summary>
         //Delete  Counter
    	[Route("api/Counter/{}")]
    	[HttpDelete]
        public async Task Delete([FromRoute]int )
        {
            var deleteTrans=new trans.CounterTransactions();
			var  counterDelete=new transModel.CounterDelete(){= };			
            await deleteTrans.Delete(counterDelete);            
        }
        */
        
        
        
    }
}


