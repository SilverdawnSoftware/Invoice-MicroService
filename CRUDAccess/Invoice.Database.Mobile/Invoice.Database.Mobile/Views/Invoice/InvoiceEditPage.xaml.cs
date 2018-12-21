// ALLOWOVERWRITE-519028742EA37BA6E4F8F27069DB8B1D

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Mobile.ViewModels;
using Database.Mobile.Views.InvoiceLine;

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
		}
		
		
           	
        public async System.Threading.Tasks.Task ShowInvoiceLines(InvoiceLineIndexViewModel invoiceLineIndexViewModel)
	    {
	        var page = new InvoiceLineIndexPage();
	        await Navigation.PushAsync(page);
	        NavigationPage.SetHasBackButton(page, true);
	        page.BindingContext = invoiceLineIndexViewModel;
        }           	
           	
		
		
	}
}