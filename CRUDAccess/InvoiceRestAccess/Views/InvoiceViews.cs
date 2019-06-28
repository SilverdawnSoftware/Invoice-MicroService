// ALLOWOVERWRITE-89EA8517031CD77D016A8C268E8F039D-BF1ADB525765F9AB19BA4F54CF0C07F4

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
    public partial class InvoiceViews
    {
        
    	public async Task<List<InvoiceView>> GetAll()
        {
        	try
            {       
	            var client = new HttpClient();
	          
	            var serializer = new DataContractJsonSerializer(typeof(List<InvoiceView>),new DataContractJsonSerializerSettings()
	            {
	                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            });
	
	            var stream = await client.GetStreamAsync("http://localhost:44443/api/invoice/all");
	
	            var views = serializer.ReadObject(stream) as List<InvoiceView>;
	            
	            return views;
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }    
        }
    
    
    	
    	public async Task<InvoiceView> Get(int invoiceId)
    	{
    		try
            {
	    		var client = new HttpClient();
	
	            var serializer = new DataContractJsonSerializer(typeof(InvoiceView),new DataContractJsonSerializerSettings()
	            {
	                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            });
	
	            var stream = await client.GetStreamAsync($"http://localhost:44443/api/invoice/{invoiceId}");
	
	            var view = serializer.ReadObject(stream) as InvoiceView;
	
	            return view;
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }    
    	
    	}
    	
    	
    	
    	
    	
		
		 /// <summary>
        /// Find all Invoices for Customer
        /// </summary>
		
		public async Task<List<InvoiceView>> GetAllForCustomer(int customerId)
        {
        	try
            {
	            var client = new HttpClient();
	          
	            var serializer = new DataContractJsonSerializer(typeof(List<InvoiceView>),new DataContractJsonSerializerSettings()
	            {
	                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            });
	
	            var stream = await client.GetStreamAsync($"http://localhost:44443/api/customer/{customerId}/tasks");
	
	            var views = serializer.ReadObject(stream) as List<InvoiceView>;
	            
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

