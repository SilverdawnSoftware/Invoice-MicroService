// ALLOWOVERWRITE-0D1D727CA636C51F8D20F8590FE8AB85

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Database.Views;
using Database.Views.Model;
using Database.Mobile.Annotations;

using Xamarin.Forms;

namespace Database.Mobile.ViewModels
{
    public class InvoiceIndexViewModel : INotifyPropertyChanged
    {


		 public ICommand AddInvoiceCommand { get; private set; }

        public InvoiceIndexViewModel()
        {
            AddInvoiceCommand = new Command(async () => await AddInvoice());
        }

        private async Task AddInvoice()
        {
            var invoice=new InvoiceEditViewModel();

 			invoice.CustomerCustomerId= CustomerCustomerId; 
            MessagingCenter.Send<InvoiceIndexViewModel, InvoiceEditViewModel>(this, "AddInvoice", invoice);
        }

 		public int CustomerCustomerId {get; set;} 


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<InvoiceView> InvoiceViews { get; set; } = new ObservableCollection<InvoiceView>();

		
        public async System.Threading.Tasks.Task GetInvoicesForCustomer(int customerCustomerId)
        {
        	CustomerCustomerId=customerCustomerId;
            var Invoices = new InvoiceViews();
            var temp = await Invoices.GetAllForCustomer(customerCustomerId);
            InvoiceViews.Clear();
            foreach (var invoiceView in temp)
            {
                InvoiceViews.Add(invoiceView);
            }
        }
        
        
    }
}

