// ALLOWOVERWRITE-DA5E1B49DD6577DA68E77031025400EA

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SilverdawnSoftware.Exceptions;
using SilverdawnSoftware.Invoice.RESTAPI.Services;

using SilverdawnSoftware.Invoice.CQRS.Querys.Results;
using SilverdawnSoftware.Invoice.CQRS.Commands.Invoice;
using SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;


namespace SilverdawnSoftware.Invoice.RESTAPI.Controllers
{

	
    public partial class InvoiceAPIController : Controller
    {
   		private readonly IOrleansService _orleansService;

        public InvoiceAPIController(IOrleansService orleansService)
        {
            _orleansService = orleansService;
        }
    
    	  /// <summary>
        /// 
        /// </summary>   	
    	[Route("api/Invoice")]
    	[HttpPost]
        public async Task<ActionResult<IInvoiceView>> Add([FromBody]InvoiceCreate invoiceCreate)
        {
            try
            {
                var grain = _orleansService.Client.GetGrain<IInvoiceCreateCommand>(0);
                var result=await  grain.InvoiceCreate(invoiceCreate);
                if (result.__CQRSSuccessful)
                   return new ActionResult<IInvoiceView>(result);
                else
                {
                    return new ContentResult() {StatusCode = result.__CQRSStatusCode, Content = result.__CQRSErrorMessage, ContentType = "text/plain"};
                }
            }
            catch (Exception e)
            {
                 LogFactory.GetLogger().Log(LogLevel.Error,e);
                 return new ContentResult() { StatusCode = 500, Content = "Fatal API Error", ContentType = "text/plain" };     
            } 
        }
    	  /// <summary>
        /// 
        /// </summary>   	
    	[Route("api/Invoice/{InvoiceId}/Email")]
    	[HttpPost]
        public async Task<ActionResult<IInvoiceView>> Add([FromBody]InvoiceEmail invoiceEmail)
        {
            try
            {
                var grain = _orleansService.Client.GetGrain<IInvoiceEmailCommand>(0);
                var result=await  grain.InvoiceEmail(invoiceEmail);
                if (result.__CQRSSuccessful)
                   return new ActionResult<IInvoiceView>(result);
                else
                {
                    return new ContentResult() {StatusCode = result.__CQRSStatusCode, Content = result.__CQRSErrorMessage, ContentType = "text/plain"};
                }
            }
            catch (Exception e)
            {
                 LogFactory.GetLogger().Log(LogLevel.Error,e);
                 return new ContentResult() { StatusCode = 500, Content = "Fatal API Error", ContentType = "text/plain" };     
            } 
        }
         /// <summary>
        /// 
        /// </summary>	
    	[Route("api/Invoice/{InvoiceId}")]
    	[HttpPut]
        public async Task<ActionResult<IInvoiceView>> Update([FromRoute]int id,[FromBody]InvoiceUpdate invoiceUpdate)
        {
            try
            {
               var grain = _orleansService.Client.GetGrain<InvoiceUpdateCommand>(0);
               var result=await grain.InvoiceUpdate(invoiceUpdate);
               if (result.__CQRSSuccessful)
                    return new ActionResult<IInvoiceView>(result);
                else
                {
                    return new ContentResult() {StatusCode = result.__CQRSStatusCode, Content = result.__CQRSErrorMessage, ContentType = "text/plain"};
                }
            }
            catch (Exception e)
            {
                 LogFactory.GetLogger().Log(LogLevel.Error,e);
                 return new ContentResult() { StatusCode = 500, Content = "Fatal API Error", ContentType = "text/plain" };   
            }                      
        }
         /// <summary>
        /// 
        /// </summary>
    	[Route("api/Invoice/{InvoiceId}")]
    	[HttpDelete]
        public async Task<ActionResult> Delete([FromRoute]int id,[FromBody]InvoiceDelete invoiceDelete)
        {
            try
            {
                var grain = _orleansService.Client.GetGrain<InvoiceDeleteCommand>(0);
                var result=await grain.InvoiceDelete(invoiceDelete);
                if (result.__CQRSSuccessful)
                   return new ContentResult() {StatusCode = 200};
                else
                {
                    return new ContentResult() {StatusCode = result.__CQRSStatusCode, Content = result.__CQRSErrorMessage, ContentType = "text/plain"};
                }
            }
            catch (Exception e)
            {
                 LogFactory.GetLogger().Log(LogLevel.Error,e);
                 return new ContentResult() { StatusCode = 500, Content = "Fatal API Error", ContentType = "text/plain" };          
            } 
        }
         /// <summary>
        /// 
        /// </summary>	
    	[Route("api/Invoice/{InvoiceId}/Pay")]
    	[HttpPut]
        public async Task<ActionResult<IInvoiceView>> Update([FromRoute]int id,[FromBody]InvoicePay invoicePay)
        {
            try
            {
               var grain = _orleansService.Client.GetGrain<InvoicePayCommand>(0);
               var result=await grain.InvoicePay(invoicePay);
               if (result.__CQRSSuccessful)
                    return new ActionResult<IInvoiceView>(result);
                else
                {
                    return new ContentResult() {StatusCode = result.__CQRSStatusCode, Content = result.__CQRSErrorMessage, ContentType = "text/plain"};
                }
            }
            catch (Exception e)
            {
                 LogFactory.GetLogger().Log(LogLevel.Error,e);
                 return new ContentResult() { StatusCode = 500, Content = "Fatal API Error", ContentType = "text/plain" };   
            }                      
        }
         /// <summary>
        /// 
        /// </summary>	
    	[Route("api/Invoice/{InvoiceId}/Cancel")]
    	[HttpPut]
        public async Task<ActionResult<IInvoiceView>> Update([FromRoute]int id,[FromBody]InvoiceCancel invoiceCancel)
        {
            try
            {
               var grain = _orleansService.Client.GetGrain<InvoiceCancelCommand>(0);
               var result=await grain.InvoiceCancel(invoiceCancel);
               if (result.__CQRSSuccessful)
                    return new ActionResult<IInvoiceView>(result);
                else
                {
                    return new ContentResult() {StatusCode = result.__CQRSStatusCode, Content = result.__CQRSErrorMessage, ContentType = "text/plain"};
                }
            }
            catch (Exception e)
            {
                 LogFactory.GetLogger().Log(LogLevel.Error,e);
                 return new ContentResult() { StatusCode = 500, Content = "Fatal API Error", ContentType = "text/plain" };   
            }                      
        }
         /// <summary>
        /// 
        /// </summary>	
    	[Route("api/Invoice/{InvoiceId}/Notes")]
    	[HttpPut]
        public async Task<ActionResult<IInvoiceView>> Update([FromRoute]int id,[FromBody]InvoiceUpdateNotes invoiceUpdateNotes)
        {
            try
            {
               var grain = _orleansService.Client.GetGrain<InvoiceUpdateNotesCommand>(0);
               var result=await grain.InvoiceUpdateNotes(invoiceUpdateNotes);
               if (result.__CQRSSuccessful)
                    return new ActionResult<IInvoiceView>(result);
                else
                {
                    return new ContentResult() {StatusCode = result.__CQRSStatusCode, Content = result.__CQRSErrorMessage, ContentType = "text/plain"};
                }
            }
            catch (Exception e)
            {
                 LogFactory.GetLogger().Log(LogLevel.Error,e);
                 return new ContentResult() { StatusCode = 500, Content = "Fatal API Error", ContentType = "text/plain" };   
            }                      
        }

    	
    	
        
    }
}





