// ALLOWOVERWRITE-AD081114A0E81C4457C2ACAF34643891

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
    public partial class AddressViews
    {
        
    	public async Task<List<AddressView>> GetAll()
        {
        	try
            {       
	            var client = new HttpClient();
	          
	            var serializer = new DataContractJsonSerializer(typeof(List<AddressView>),new DataContractJsonSerializerSettings()
	            {
	                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            });
	
	            var stream = await client.GetStreamAsync("http://localhost:44443/api/address/all");
	
	            var views = serializer.ReadObject(stream) as List<AddressView>;
	            
	            return views;
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }    
        }
    
    
    	
    	public async Task<AddressView> Get(int addressId)
    	{
    		try
            {
	    		var client = new HttpClient();
	
	            var serializer = new DataContractJsonSerializer(typeof(AddressView),new DataContractJsonSerializerSettings()
	            {
	                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            });
	
	            var stream = await client.GetStreamAsync($"http://localhost:44443/api/address/{addressId}");
	
	            var view = serializer.ReadObject(stream) as AddressView;
	
	            return view;
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }    
    	
    	}
    	
    	
    	
    	
    	
		
		 /// <summary>
        /// Find all Addresss for Customer
        /// </summary>
		
		public async Task<List<AddressView>> GetAllForCustomer(int customerId)
        {
        	try
            {
	            var client = new HttpClient();
	          
	            var serializer = new DataContractJsonSerializer(typeof(List<AddressView>),new DataContractJsonSerializerSettings()
	            {
	                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            });
	
	            var stream = await client.GetStreamAsync($"http://localhost:44443/api/customer/{customerId}/tasks");
	
	            var views = serializer.ReadObject(stream) as List<AddressView>;
	            
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

