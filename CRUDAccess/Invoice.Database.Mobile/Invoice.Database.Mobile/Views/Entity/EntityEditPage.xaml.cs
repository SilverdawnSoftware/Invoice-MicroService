// ALLOWOVERWRITE-58BB647C87C5419ED868000286DF626E

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Mobile.ViewModels;
using Database.Mobile.Views.Customer;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Database.Mobile.Views.Entity
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class EntityEditPage : ContentPage
	{
		public EntityEditPage ()
		{
			InitializeComponent ();			
			MessagingCenter.Subscribe<EntityEditViewModel>(this, "Save error",model => DisplayAlert("Save error", "Unable to save changes.", "Close") );			 			 
           	MessagingCenter.Subscribe<EntityEditViewModel, CustomerIndexViewModel>(this, "ShowCustomers",async  (sender, arg) => { await ShowCustomers(arg); });
		}
		
		
           	
        public async System.Threading.Tasks.Task ShowCustomers(CustomerIndexViewModel customerIndexViewModel)
	    {
	        var page = new CustomerIndexPage();
	        await Navigation.PushAsync(page);
	        NavigationPage.SetHasBackButton(page, true);
	        page.BindingContext = customerIndexViewModel;
        }           	
           	
		
		
	}
}