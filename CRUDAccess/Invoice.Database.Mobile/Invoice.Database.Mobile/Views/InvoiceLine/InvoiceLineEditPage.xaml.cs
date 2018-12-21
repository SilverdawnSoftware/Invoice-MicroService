// ALLOWOVERWRITE-5C285A8B03C45F88D0B9542221DDD995

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Mobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Database.Mobile.Views.InvoiceLine
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class InvoiceLineEditPage : ContentPage
	{
		public InvoiceLineEditPage ()
		{
			InitializeComponent ();			
			MessagingCenter.Subscribe<InvoiceLineEditViewModel>(this, "Save error",model => DisplayAlert("Save error", "Unable to save changes.", "Close") );			 			 
		}
		
		
		
		
	}
}