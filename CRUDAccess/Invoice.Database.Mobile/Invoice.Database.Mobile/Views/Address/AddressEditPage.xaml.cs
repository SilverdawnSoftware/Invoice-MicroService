// ALLOWOVERWRITE-E2AEE6451F6DC2212A888356EC3F266D

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Database.Mobile.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Database.Mobile.Views.Address
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AddressEditPage : ContentPage
	{
		public AddressEditPage ()
		{
			InitializeComponent ();			
			MessagingCenter.Subscribe<AddressEditViewModel>(this, "Save error",model => DisplayAlert("Save error", "Unable to save changes.", "Close") );			 			 
		}
		
		
		
		
	}
}