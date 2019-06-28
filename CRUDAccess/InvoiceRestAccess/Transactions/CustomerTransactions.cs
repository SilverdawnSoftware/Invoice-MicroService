// ALLOWOVERWRITE-CC72DDDF0062D7FF6D9EB8CD7468DE4E-64D901ADC45AEBE6C8EF1B88019E89C2

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
    public  class CustomerTransactions
    {
        public async Task<CustomerView> CustomerAdd(CustomerAdd add)
        {
        	try
            {
	            string json = "";
	
	            var client = new HttpClient();
	
	            using (var ms = new MemoryStream())
	            {
	                var serializer = new DataContractJsonSerializer(typeof(CustomerAdd));
	                serializer.WriteObject(ms, add);
	                ms.Position = 0;
	                StreamReader sr = new StreamReader(ms);
	                json = sr.ReadToEnd();
	            }
	
	            var stream = await client.PostAsync("http://localhost:44443/api/customer", new StringContent(json, Encoding.UTF8, "application/json"));
	
	            using (var ms = new MemoryStream())
	            {
	                var serializer = new DataContractJsonSerializer(typeof(CustomerView),new DataContractJsonSerializerSettings()
	            	{
	                	DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            	});
	                await stream.Content.CopyToAsync(ms);
	                ms.Position = 0;
	                var view = serializer.ReadObject(ms) as CustomerView;
	                return view;
	            }
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;
              
            }    
        }
 
        public async Task<CustomerView> CustomerUpdate(CustomerUpdate update)
        {
        	try
            {
	            string json = "";
	
	            var client = new HttpClient();
	
	            using (var ms = new MemoryStream())
	            {
	                var serializer = new DataContractJsonSerializer(typeof(CustomerUpdate),new DataContractJsonSerializerSettings()
	            	{
	                	DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            	});
	                serializer.WriteObject(ms, update);
	                ms.Position = 0;
	                StreamReader sr = new StreamReader(ms);
	                json = sr.ReadToEnd();
	            }
	
	            var stream = await client.PutAsync($"http://localhost:44443/api/customer/{update.CustomerId}", new StringContent(json, Encoding.UTF8, "application/json"));
	
	            using (var ms = new MemoryStream())
	            {
	                var serializer = new DataContractJsonSerializer(typeof(CustomerView));
	                await stream.Content.CopyToAsync(ms);
	                ms.Position = 0;
	                var view = serializer.ReadObject(ms) as CustomerView;
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

