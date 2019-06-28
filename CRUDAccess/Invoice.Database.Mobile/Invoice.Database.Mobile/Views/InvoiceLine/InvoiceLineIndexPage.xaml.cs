// ALLOWOVERWRITE-03D65EB5615555E8C6BECD943F54D78D-59A20020C038D35CD57CC810E0C636EB

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

namespace Database.Mobile.Views.InvoiceLine
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InvoiceLineIndexPage : ContentPage
    {
        public ObservableCollection<InvoiceLineView> Items { get; set; }=new ObservableCollection<InvoiceLineView>();

        public InvoiceLineIndexPage()
        {
            InitializeComponent();
			MessagingCenter.Subscribe<InvoiceLineIndexViewModel, InvoiceLineEditViewModel>(this, "AddInvoiceLine", async (sender, arg) => { await AddInvoiceLines(arg);});                   
        }
        
        
        private async System.Threading.Tasks.Task AddInvoiceLines(InvoiceLineEditViewModel invoiceLineEditViewModel)
        {

            var page = new InvoiceLineEditPage();
            page.BindingContext = invoiceLineEditViewModel;
            await Navigation.PushAsync(page);
            NavigationPage.SetHasBackButton(page, true);
        }
        
        

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");
            var page = new InvoiceLineEditPage();
            await Navigation.PushAsync(page);
            NavigationPage.SetHasBackButton(page, true);
			await ((InvoiceLineEditViewModel)page.BindingContext).Load(((InvoiceLineView) e.Item).InvoiceLineId);
            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }


        
    }

}


