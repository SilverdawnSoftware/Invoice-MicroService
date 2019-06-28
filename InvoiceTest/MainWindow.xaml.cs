using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EasyHttp.Http;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Configuration;
using SilverdawnSoftware.Invoice.CQRS.Commands.Invoice.Models;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Commands.Invoice;
using SilverdawnSoftware.Invoice.Interfaces.CQRS.Querys.Results.Models;

namespace InvoiceTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public IClusterClient Client { get; set; }

        public MainWindow()
        {
            InitializeComponent();


        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var toAdd = new InvoiceAdd() { TermsAndConditions = Guid.NewGuid().ToString() };

            var http = new EasyHttp.Http.HttpClient();

           // http.Post("http://localhost:32772/api/Invoice", toAdd, HttpContentTypes.ApplicationJson);
          var response=  http.Post("http://localhost:55526/api/Invoice", toAdd, HttpContentTypes.ApplicationJson);
          MessageBox.Show(response.StatusCode.ToString());
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

        private async void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
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


                var toAdd = new InvoiceAdd() { TermsAndConditions = Guid.NewGuid().ToString() };
                var grain = client.GetGrain<IInvoiceAddCommand>(0);
                var result = await grain.InvoiceAdd(toAdd);
                MessageBox.Show(result.__CQRSStatusCode.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
