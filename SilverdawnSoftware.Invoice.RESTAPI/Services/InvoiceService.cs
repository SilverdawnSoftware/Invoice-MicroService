using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Configuration;

namespace SilverdawnSoftware.Invoice.RESTAPI.Services
{

    public interface IOrleansService
    {
        IClusterClient Client { get; }
    }

    public class OrleansService:IOrleansService
    {

        public IClusterClient Client { get; set; }

        public  OrleansService()
        {
            var client = new ClientBuilder()
                .UseLocalhostClustering()
                .Configure<ClusterOptions>(options =>
                {
                    options.ClusterId = "dev";
                    options.ServiceId = "SilverdawnSoftwareInvoiceApp";
                })
                .ConfigureLogging(logging => logging.AddConsole())
                .Build();

             client.Connect(CreateRetryFilter()).Wait();

             Client = client;
        }


        private static Func<Exception, Task<bool>> CreateRetryFilter(int maxAttempts = 5)
        {
            var attempt = 0;
            return RetryFilter;

            async Task<bool> RetryFilter(Exception exception)
            {
                attempt++;
                Console.WriteLine($"Cluster client attempt {attempt} of {maxAttempts} failed to connect to cluster.  Exception: {exception}");
                if (attempt > maxAttempts)
                {
                    return false;
                }

                await Task.Delay(TimeSpan.FromSeconds(4));
                return true;
            }
        }
    }
}
