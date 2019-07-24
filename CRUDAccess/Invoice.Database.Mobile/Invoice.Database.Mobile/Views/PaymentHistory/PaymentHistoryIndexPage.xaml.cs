// ALLOWOVERWRITE-C500A9CF5A874BC71C13239968D5FBB2
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

namespace Database.Mobile.Views.PaymentHistory
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaymentHistoryIndexPage : ContentPage
    {
        public ObservableCollection<PaymentHistoryView> Items { get; set; }=new ObservableCollection<PaymentHistoryView>();

        public PaymentHistoryIndexPage()
        {
            InitializeComponent();
			MessagingCenter.Subscribe<PaymentHistoryIndexViewModel, PaymentHistoryEditViewModel>(this, "AddPaymentHistory", async (sender, arg) => { await AddPaymentHistorys(arg);});                   
        }
        private async System.Threading.Tasks.Task AddPaymentHistorys(PaymentHistoryEditViewModel paymentHistoryEditViewModel)
        {
            var page = new PaymentHistoryEditPage();
            page.BindingContext = paymentHistoryEditViewModel;
            await Navigation.PushAsync(page);
            NavigationPage.SetHasBackButton(page, true);
        }

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;
            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");
            var page = new PaymentHistoryEditPage();
            await Navigation.PushAsync(page);
            NavigationPage.SetHasBackButton(page, true);
			await ((PaymentHistoryEditViewModel)page.BindingContext).Load(((PaymentHistoryView) e.Item).PaymentHistoryId);
            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }        
    }
}



