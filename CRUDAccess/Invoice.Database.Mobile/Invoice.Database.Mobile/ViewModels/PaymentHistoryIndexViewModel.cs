// ALLOWOVERWRITE-63F835A30B455D4B626533DAB1AF8A9F

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
    public class PaymentHistoryIndexViewModel : INotifyPropertyChanged
    {


		 public ICommand AddPaymentHistoryCommand { get; private set; }

        public PaymentHistoryIndexViewModel()
        {
            AddPaymentHistoryCommand = new Command(async () => await AddPaymentHistory());
        }

        private async Task AddPaymentHistory()
        {
            var paymentHistory=new PaymentHistoryEditViewModel();

 			paymentHistory.InvoiceInvoiceId= InvoiceInvoiceId; 
            MessagingCenter.Send<PaymentHistoryIndexViewModel, PaymentHistoryEditViewModel>(this, "AddPaymentHistory", paymentHistory);
        }

 		public int InvoiceInvoiceId {get; set;} 


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<PaymentHistoryView> PaymentHistoryViews { get; set; } = new ObservableCollection<PaymentHistoryView>();

		
        public async System.Threading.Tasks.Task GetPaymentHistorysForInvoice(int invoiceInvoiceId)
        {
        	InvoiceInvoiceId=invoiceInvoiceId;
            var PaymentHistorys = new PaymentHistoryViews();
            var temp = await PaymentHistorys.GetAllForInvoice(invoiceInvoiceId);
            PaymentHistoryViews.Clear();
            foreach (var paymentHistoryView in temp)
            {
                PaymentHistoryViews.Add(paymentHistoryView);
            }
        }
        
        
    }
}


