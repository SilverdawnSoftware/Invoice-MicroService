// ALLOWOVERWRITE-4A37111CC2E152A81046C319AA620AEA

using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using Database.Views.Model;


namespace Database.Views
{
    public partial class PaymentHistoryViews
    {
        
    	public async Task<List<PaymentHistoryView>> GetAll()
        {
        	try
            {       
	            var client = new HttpClient();
	          
	            var serializer = new DataContractJsonSerializer(typeof(List<PaymentHistoryView>),new DataContractJsonSerializerSettings()
	            {
	                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            });
	
	            var stream = await client.GetStreamAsync("http://localhost:44443/api/paymentHistory/all");
	
	            var views = serializer.ReadObject(stream) as List<PaymentHistoryView>;
	            
	            return views;
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }    
        }
    
    
    	
    	public async Task<PaymentHistoryView> Get(int paymentHistoryId)
    	{
    		try
            {
	    		var client = new HttpClient();
	
	            var serializer = new DataContractJsonSerializer(typeof(PaymentHistoryView),new DataContractJsonSerializerSettings()
	            {
	                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            });
	
	            var stream = await client.GetStreamAsync($"http://localhost:44443/api/paymentHistory/{paymentHistoryId}");
	
	            var view = serializer.ReadObject(stream) as PaymentHistoryView;
	
	            return view;
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }    
    	
    	}
    	
    	
    	
    	
    	
		
		 /// <summary>
        /// Find all PaymentHistorys for Invoice
        /// </summary>
		
		public async Task<List<PaymentHistoryView>> GetAllForInvoice(int invoiceId)
        {
        	try
            {
	            var client = new HttpClient();
	          
	            var serializer = new DataContractJsonSerializer(typeof(List<PaymentHistoryView>),new DataContractJsonSerializerSettings()
	            {
	                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            });
	
	            var stream = await client.GetStreamAsync($"http://localhost:44443/api/invoice/{invoiceId}/tasks");
	
	            var views = serializer.ReadObject(stream) as List<PaymentHistoryView>;
	            
	            return views;
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;
              
            }    
        }
		    	
    	
    }
}

