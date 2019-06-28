// ALLOWOVERWRITE-1253973D0546409653D3A76026371EED-13634C61A2128521D54F5AFE772CA8B1

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

namespace Database.Mobile.Views.Customer
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CustomerIndexPage : ContentPage
    {
        public ObservableCollection<CustomerView> Items { get; set; }=new ObservableCollection<CustomerView>();

        public CustomerIndexPage()
        {
            InitializeComponent();
			MessagingCenter.Subscribe<CustomerIndexViewModel, CustomerEditViewModel>(this, "AddCustomer", async (sender, arg) => { await AddCustomers(arg);});                   
        }
        
        
        private async System.Threading.Tasks.Task AddCustomers(CustomerEditViewModel customerEditViewModel)
        {

            var page = new CustomerEditPage();
            page.BindingContext = customerEditViewModel;
            await Navigation.PushAsync(page);
            NavigationPage.SetHasBackButton(page, true);
        }
        
        

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");
            var page = new CustomerEditPage();
            await Navigation.PushAsync(page);
            NavigationPage.SetHasBackButton(page, true);
			await ((CustomerEditViewModel)page.BindingContext).Load(((CustomerView) e.Item).CustomerId);
            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }


        
    }

}


