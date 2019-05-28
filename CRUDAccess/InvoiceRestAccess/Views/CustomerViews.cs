// ALLOWOVERWRITE-A8507A56D793F161B643D32824EAD7C5

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
    public partial class CustomerViews
    {
        
    	public async Task<List<CustomerView>> GetAll()
        {
        	try
            {       
	            var client = new HttpClient();
	          
	            var serializer = new DataContractJsonSerializer(typeof(List<CustomerView>),new DataContractJsonSerializerSettings()
	            {
	                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            });
	
	            var stream = await client.GetStreamAsync("http://localhost:44443/api/customer/all");
	
	            var views = serializer.ReadObject(stream) as List<CustomerView>;
	            
	            return views;
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }    
        }
    
    
    	
    	public async Task<CustomerView> Get(int customerId)
    	{
    		try
            {
	    		var client = new HttpClient();
	
	            var serializer = new DataContractJsonSerializer(typeof(CustomerView),new DataContractJsonSerializerSettings()
	            {
	                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            });
	
	            var stream = await client.GetStreamAsync($"http://localhost:44443/api/customer/{customerId}");
	
	            var view = serializer.ReadObject(stream) as CustomerView;
	
	            return view;
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }    
    	
    	}
    	
    	
    	
    	
    	
		
		 /// <summary>
        /// Find all Customers for Entity
        /// </summary>
		
		public async Task<List<CustomerView>> GetAllForEntity(int entityId)
        {
        	try
            {
	            var client = new HttpClient();
	          
	            var serializer = new DataContractJsonSerializer(typeof(List<CustomerView>),new DataContractJsonSerializerSettings()
	            {
	                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            });
	
	            var stream = await client.GetStreamAsync($"http://localhost:44443/api/entity/{entityId}/tasks");
	
	            var views = serializer.ReadObject(stream) as List<CustomerView>;
	            
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

