// ALLOWOVERWRITE-2DA721C45ECA290394380B308A296219

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Mobile.ViewModels;
using Database.Mobile.Views.InvoiceLine;
using Database.Mobile.Views.PaymentHistory;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Database.Mobile.Views.Invoice
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InvoiceEditPage : ContentPage
	{
		public InvoiceEditPage ()
		{
			InitializeComponent ();			
			MessagingCenter.Subscribe<InvoiceEditViewModel>(this, "Save error",model => DisplayAlert("Save error", "Unable to save changes.", "Close") );			 			 
           	MessagingCenter.Subscribe<InvoiceEditViewModel, InvoiceLineIndexViewModel>(this, "ShowInvoiceLines",async  (sender, arg) => { await ShowInvoiceLines(arg); });
           	MessagingCenter.Subscribe<InvoiceEditViewModel, PaymentHistoryIndexViewModel>(this, "ShowPaymentHistorys",async  (sender, arg) => { await ShowPaymentHistorys(arg); });
		}
		
		
           	
        public async System.Threading.Tasks.Task ShowInvoiceLines(InvoiceLineIndexViewModel invoiceLineIndexViewModel)
	    {
	        var page = new InvoiceLineIndexPage();
	        await Navigation.PushAsync(page);
	        NavigationPage.SetHasBackButton(page, true);
	        page.BindingContext = invoiceLineIndexViewModel;
        }           	
           	
           	
        public async System.Threading.Tasks.Task ShowPaymentHistorys(PaymentHistoryIndexViewModel paymentHistoryIndexViewModel)
	    {
	        var page = new PaymentHistoryIndexPage();
	        await Navigation.PushAsync(page);
	        NavigationPage.SetHasBackButton(page, true);
	        page.BindingContext = paymentHistoryIndexViewModel;
        }           	
           	
		
		
	}
}
