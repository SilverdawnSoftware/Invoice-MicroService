// ALLOWOVERWRITE-31809F2F477200ED5A4704E5ECCA201E

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
    public partial class CounterViews
    {
        
    	public async Task<List<CounterView>> GetAll()
        {
        	try
            {       
	            var client = new HttpClient();
	          
	            var serializer = new DataContractJsonSerializer(typeof(List<CounterView>),new DataContractJsonSerializerSettings()
	            {
	                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            });
	
	            var stream = await client.GetStreamAsync("http://localhost:44443/api/counter/all");
	
	            var views = serializer.ReadObject(stream) as List<CounterView>;
	            
	            return views;
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }    
        }
    
    
    	
    	public async Task<CounterView> Get(int name)
    	{
    		try
            {
	    		var client = new HttpClient();
	
	            var serializer = new DataContractJsonSerializer(typeof(CounterView),new DataContractJsonSerializerSettings()
	            {
	                DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            });
	
	            var stream = await client.GetStreamAsync($"http://localhost:44443/api/counter/{name}");
	
	            var view = serializer.ReadObject(stream) as CounterView;
	
	            return view;
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;              
            }    
    	
    	}
    	
    	
    	
    	
    	
    	
    }
}

