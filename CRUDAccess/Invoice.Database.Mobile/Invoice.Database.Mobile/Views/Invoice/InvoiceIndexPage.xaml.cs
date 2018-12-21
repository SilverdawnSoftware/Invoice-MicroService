// ALLOWOVERWRITE-144F7565C97E37EFF4053FF51EFC2C87

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

namespace Database.Mobile.Views.Invoice
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InvoiceIndexPage : ContentPage
    {
        public ObservableCollection<InvoiceView> Items { get; set; }=new ObservableCollection<InvoiceView>();

        public InvoiceIndexPage()
        {
            InitializeComponent();
			MessagingCenter.Subscribe<InvoiceIndexViewModel, InvoiceEditViewModel>(this, "AddInvoice", async (sender, arg) => { await AddInvoices(arg);});                   
        }
        
        
        private async System.Threading.Tasks.Task AddInvoices(InvoiceEditViewModel invoiceEditViewModel)
        {

            var page = new InvoiceEditPage();
            page.BindingContext = invoiceEditViewModel;
            await Navigation.PushAsync(page);
            NavigationPage.SetHasBackButton(page, true);
        }
        
        

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");
            var page = new InvoiceEditPage();
            await Navigation.PushAsync(page);
            NavigationPage.SetHasBackButton(page, true);
			await ((InvoiceEditViewModel)page.BindingContext).Load(((InvoiceView) e.Item).InvoiceId);
            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }


        
    }

}

