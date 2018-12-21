// ALLOWOVERWRITE-BDCAC4758B58647CF96EDF258D990010

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Mobile.ViewModels;
using Database.Mobile.Views.Address;
using Database.Mobile.Views.Invoice;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Database.Mobile.Views.Customer
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CustomerEditPage : ContentPage
	{
		public CustomerEditPage ()
		{
			InitializeComponent ();			
			MessagingCenter.Subscribe<CustomerEditViewModel>(this, "Save error",model => DisplayAlert("Save error", "Unable to save changes.", "Close") );			 			 
           	MessagingCenter.Subscribe<CustomerEditViewModel, AddressIndexViewModel>(this, "ShowAddresss",async  (sender, arg) => { await ShowAddresss(arg); });
           	MessagingCenter.Subscribe<CustomerEditViewModel, InvoiceIndexViewModel>(this, "ShowInvoices",async  (sender, arg) => { await ShowInvoices(arg); });
		}
		
		
           	
        public async System.Threading.Tasks.Task ShowAddresss(AddressIndexViewModel addressIndexViewModel)
	    {
	        var page = new AddressIndexPage();
	        await Navigation.PushAsync(page);
	        NavigationPage.SetHasBackButton(page, true);
	        page.BindingContext = addressIndexViewModel;
        }           	
           	
           	
        public async System.Threading.Tasks.Task ShowInvoices(InvoiceIndexViewModel invoiceIndexViewModel)
	    {
	        var page = new InvoiceIndexPage();
	        await Navigation.PushAsync(page);
	        NavigationPage.SetHasBackButton(page, true);
	        page.BindingContext = invoiceIndexViewModel;
        }           	
           	
		
		
	}
}