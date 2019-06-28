// ALLOWOVERWRITE-25D619D7A3B0A531C0F50527289B89C3-253BE1063811707D8410B8165B63154F

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Mobile.ViewModels;
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
           	MessagingCenter.Subscribe<CustomerEditViewModel, InvoiceIndexViewModel>(this, "ShowInvoices",async  (sender, arg) => { await ShowInvoices(arg); });
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
