// ALLOWOVERWRITE-7EB27F50E7644A16BB31C55B86D9D629

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
    public  class InvoiceLineTransactions
    {
        public async Task<InvoiceLineView> InvoiceLineAdd(InvoiceLineAdd add)
        {
        	try
            {
	            string json = "";
	
	            var client = new HttpClient();
	
	            using (var ms = new MemoryStream())
	            {
	                var serializer = new DataContractJsonSerializer(typeof(InvoiceLineAdd));
	                serializer.WriteObject(ms, add);
	                ms.Position = 0;
	                StreamReader sr = new StreamReader(ms);
	                json = sr.ReadToEnd();
	            }
	
	            var stream = await client.PostAsync("http://localhost:44443/api/invoiceLine", new StringContent(json, Encoding.UTF8, "application/json"));
	
	            using (var ms = new MemoryStream())
	            {
	                var serializer = new DataContractJsonSerializer(typeof(InvoiceLineView),new DataContractJsonSerializerSettings()
	            	{
	                	DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            	});
	                await stream.Content.CopyToAsync(ms);
	                ms.Position = 0;
	                var view = serializer.ReadObject(ms) as InvoiceLineView;
	                return view;
	            }
            }
            catch (Exception e)
            {
            	LogFactory.GetLogger().Log(LogLevel.Error,e);
                return null;
              
            }    
        }
 
        public async Task<InvoiceLineView> InvoiceLineUpdate(InvoiceLineUpdate update)
        {
        	try
            {
	            string json = "";
	
	            var client = new HttpClient();
	
	            using (var ms = new MemoryStream())
	            {
	                var serializer = new DataContractJsonSerializer(typeof(InvoiceLineUpdate),new DataContractJsonSerializerSettings()
	            	{
	                	DateTimeFormat = new DateTimeFormat("yyyy-MM-dd'T'HH:mm:ss")
	            	});
	                serializer.WriteObject(ms, update);
	                ms.Position = 0;
	                StreamReader sr = new StreamReader(ms);
	                json = sr.ReadToEnd();
	            }
	
	            var stream = await client.PutAsync($"http://localhost:44443/api/invoiceLine/{update.InvoiceLineId}", new StringContent(json, Encoding.UTF8, "application/json"));
	
	            using (var ms = new MemoryStream())
	            {
	                var serializer = new DataContractJsonSerializer(typeof(InvoiceLineView));
	                await stream.Content.CopyToAsync(ms);
	                ms.Position = 0;
	                var view = serializer.ReadObject(ms) as InvoiceLineView;
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

