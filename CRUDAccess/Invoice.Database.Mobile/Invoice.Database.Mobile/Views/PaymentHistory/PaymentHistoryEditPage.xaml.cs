// ALLOWOVERWRITE-83E2AF0BF73C566BDAD33F972FA17B9D

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Mobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Database.Mobile.Views.PaymentHistory
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class PaymentHistoryEditPage : ContentPage
	{
		public PaymentHistoryEditPage ()
		{
			InitializeComponent ();			
			MessagingCenter.Subscribe<PaymentHistoryEditViewModel>(this, "Save error",model => DisplayAlert("Save error", "Unable to save changes.", "Close") );			 			 
		}
		
		
		
		
	}
}
