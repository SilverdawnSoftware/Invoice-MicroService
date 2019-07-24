// ALLOWOVERWRITE-AEEC28AC52C6B0DC5C68F2B89A4632C2

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
    public  class InvoiceTransactions
    {
        public async Task<InvoiceView> InvoiceAdd(InvoiceAdd add)
        {
        	try
            {
	            string json = "";
	
	            var client = new HttpClient();
	
	            using (var ms = new MemoryStream())
	            {
	                var serializer = new DataContractJsonSerializer(typeof(InvoiceAdd));
	                serializer.WriteObject(ms, add);
	                ms.Position = 0;
	                StreamReader sr = new StreamReader(ms);
	                json = sr.ReadToEnd();
	            }
	
	            var stream = await client.PostAsync("http://localhost:44443/api/invoice", new StringContent(json, Encoding.UTF8, "application/json"));
	
	            using (var ms = new MemoryStream())
	            {
	                var serializer = new DataContractJsonSerializer(typeof(InvoiceView),new DataContractJsonSerializerSettings()
	            	{
	                	DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            	});
	                await stream.Content.CopyToAsync(ms);
	                ms.Position = 0;
	                var view = serializer.ReadObject(ms) as InvoiceView;
	                return view;
	            }
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;
              
            }    
        }
 
        public async Task<InvoiceView> InvoiceUpdate(InvoiceUpdate update)
        {
        	try
            {
	            string json = "";
	
	            var client = new HttpClient();
	
	            using (var ms = new MemoryStream())
	            {
	                var serializer = new DataContractJsonSerializer(typeof(InvoiceUpdate),new DataContractJsonSerializerSettings()
	            	{
	                	DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            	});
	                serializer.WriteObject(ms, update);
	                ms.Position = 0;
	                StreamReader sr = new StreamReader(ms);
	                json = sr.ReadToEnd();
	            }
	
	            var stream = await client.PutAsync($"http://localhost:44443/api/invoice/{update.InvoiceId}", new StringContent(json, Encoding.UTF8, "application/json"));
	
	            using (var ms = new MemoryStream())
	            {
	                var serializer = new DataContractJsonSerializer(typeof(InvoiceView));
	                await stream.Content.CopyToAsync(ms);
	                ms.Position = 0;
	                var view = serializer.ReadObject(ms) as InvoiceView;
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

