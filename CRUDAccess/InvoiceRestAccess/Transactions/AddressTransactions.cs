// ALLOWOVERWRITE-555555B2D33CD7129875C4AFF265ADA6

using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Runtime.Serialization.Json;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using SilverdawnSoftware.Exceptions;
using Database.Transactions.Model;
using Database.Views.Model;

namespace Database.Transactions
{
    public  class AddressTransactions
    {
        public async Task<AddressView> AddressAdd(AddressAdd add)
        {
        	try
            {
	            string json = "";
	
	            var client = new HttpClient();
	
	            using (var ms = new MemoryStream())
	            {
	                var serializer = new DataContractJsonSerializer(typeof(AddressAdd));
	                serializer.WriteObject(ms, add);
	                ms.Position = 0;
	                StreamReader sr = new StreamReader(ms);
	                json = sr.ReadToEnd();
	            }
	
	            var stream = await client.PostAsync("http://localhost:44443/api/address", new StringContent(json, Encoding.UTF8, "application/json"));
	
	            using (var ms = new MemoryStream())
	            {
	                var serializer = new DataContractJsonSerializer(typeof(AddressView),new DataContractJsonSerializerSettings()
	            	{
	                	DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            	});
	                await stream.Content.CopyToAsync(ms);
	                ms.Position = 0;
	                var view = serializer.ReadObject(ms) as AddressView;
	                return view;
	            }
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;
              
            }    
        }
 
        public async Task<AddressView> AddressUpdate(AddressUpdate update)
        {
        	try
            {
	            string json = "";
	
	            var client = new HttpClient();
	
	            using (var ms = new MemoryStream())
	            {
	                var serializer = new DataContractJsonSerializer(typeof(AddressUpdate),new DataContractJsonSerializerSettings()
	            	{
	                	DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            	});
	                serializer.WriteObject(ms, update);
	                ms.Position = 0;
	                StreamReader sr = new StreamReader(ms);
	                json = sr.ReadToEnd();
	            }
	
	            var stream = await client.PutAsync($"http://localhost:44443/api/address/{update.AddressId}", new StringContent(json, Encoding.UTF8, "application/json"));
	
	            using (var ms = new MemoryStream())
	            {
	                var serializer = new DataContractJsonSerializer(typeof(AddressView));
	                await stream.Content.CopyToAsync(ms);
	                ms.Position = 0;
	                var view = serializer.ReadObject(ms) as AddressView;
	                return view;
	            }
	        }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;
              
            }    
        }

    }
}

