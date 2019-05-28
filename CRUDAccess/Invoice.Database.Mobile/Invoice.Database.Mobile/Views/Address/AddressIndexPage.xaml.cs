// ALLOWOVERWRITE-E88A46C417938DB77FA2B54BE7810992

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Database.Views.Model;
using Database.Views;
using Database.Mobile.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Database.Mobile.Views.Address
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddressIndexPage : ContentPage
    {
        public ObservableCollection<AddressView> Items { get; set; }=new ObservableCollection<AddressView>();

        public AddressIndexPage()
        {
            InitializeComponent();
			MessagingCenter.Subscribe<AddressIndexViewModel, AddressEditViewModel>(this, "AddAddress", async (sender, arg) => { await AddAddresss(arg);});                   
        }
        
        
        private async System.Threading.Tasks.Task AddAddresss(AddressEditViewModel addressEditViewModel)
        {

            var page = new AddressEditPage();
            page.BindingContext = addressEditViewModel;
            await Navigation.PushAsync(page);
            NavigationPage.SetHasBackButton(page, true);
        }
        
        

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");
            var page = new AddressEditPage();
            await Navigation.PushAsync(page);
            NavigationPage.SetHasBackButton(page, true);
			await ((AddressEditViewModel)page.BindingContext).Load(((AddressView) e.Item).AddressId);
            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }


        
    }

}


