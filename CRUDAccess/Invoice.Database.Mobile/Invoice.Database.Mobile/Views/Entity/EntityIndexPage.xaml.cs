// ALLOWOVERWRITE-304159F56E7D90DF4749B406B096D5F0-5B5B8B64EAC6305CD3F9EEA0BE06D54D

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

namespace Database.Mobile.Views.Entity
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntityIndexPage : ContentPage
    {
        public ObservableCollection<EntityView> Items { get; set; }=new ObservableCollection<EntityView>();

        public EntityIndexPage()
        {
            InitializeComponent();
			MessagingCenter.Subscribe<EntityIndexViewModel, EntityEditViewModel>(this, "AddEntity", async (sender, arg) => { await AddEntitys(arg);});                   
        }
        
        
        private async System.Threading.Tasks.Task AddEntitys(EntityEditViewModel entityEditViewModel)
        {

            var page = new EntityEditPage();
            page.BindingContext = entityEditViewModel;
            await Navigation.PushAsync(page);
            NavigationPage.SetHasBackButton(page, true);
        }
        
        

        async void Handle_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            if (e.Item == null)
                return;

            //await DisplayAlert("Item Tapped", "An item was tapped.", "OK");
            var page = new EntityEditPage();
            await Navigation.PushAsync(page);
            NavigationPage.SetHasBackButton(page, true);
			await ((EntityEditViewModel)page.BindingContext).Load(((EntityView) e.Item).EntityId);
            //Deselect Item
            ((ListView)sender).SelectedItem = null;
        }


        
    }

}


