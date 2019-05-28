// ALLOWOVERWRITE-96789C96419147994E690B175499D1D9

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
    public class InvoiceLineIndexViewModel : INotifyPropertyChanged
    {


		 public ICommand AddInvoiceLineCommand { get; private set; }

        public InvoiceLineIndexViewModel()
        {
            AddInvoiceLineCommand = new Command(async () => await AddInvoiceLine());
        }

        private async Task AddInvoiceLine()
        {
            var invoiceLine=new InvoiceLineEditViewModel();

 			invoiceLine.InvoiceInvoiceId= InvoiceInvoiceId; 
            MessagingCenter.Send<InvoiceLineIndexViewModel, InvoiceLineEditViewModel>(this, "AddInvoiceLine", invoiceLine);
        }

 		public int InvoiceInvoiceId {get; set;} 


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<InvoiceLineView> InvoiceLineViews { get; set; } = new ObservableCollection<InvoiceLineView>();

		
        public async System.Threading.Tasks.Task GetInvoiceLinesForInvoice(int invoiceInvoiceId)
        {
        	InvoiceInvoiceId=invoiceInvoiceId;
            var InvoiceLines = new InvoiceLineViews();
            var temp = await InvoiceLines.GetAllForInvoice(invoiceInvoiceId);
            InvoiceLineViews.Clear();
            foreach (var invoiceLineView in temp)
            {
                InvoiceLineViews.Add(invoiceLineView);
            }
        }
        
        
    }
}


