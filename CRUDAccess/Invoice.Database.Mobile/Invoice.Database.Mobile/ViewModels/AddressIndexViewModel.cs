// ALLOWOVERWRITE-89F6A73B16DE64722C4C36A04727DFA7

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Database.Views;
using Database.Views.Model;
using Database.Mobile.Annotations;

using Xamarin.Forms;

namespace Database.Mobile.ViewModels
{
    public class AddressIndexViewModel : INotifyPropertyChanged
    {


		 public ICommand AddAddressCommand { get; private set; }

        public AddressIndexViewModel()
        {
            AddAddressCommand = new Command(async () => await AddAddress());
        }

        private async Task AddAddress()
        {
            var address=new AddressEditViewModel();

 			address.CustomerCustomerId= CustomerCustomerId; 
            MessagingCenter.Send<AddressIndexViewModel, AddressEditViewModel>(this, "AddAddress", address);
        }

 		public int CustomerCustomerId {get; set;} 


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<AddressView> AddressViews { get; set; } = new ObservableCollection<AddressView>();

		
        public async System.Threading.Tasks.Task GetAddresssForCustomer(int customerCustomerId)
        {
        	CustomerCustomerId=customerCustomerId;
            var Addresss = new AddressViews();
            var temp = await Addresss.GetAllForCustomer(customerCustomerId);
            AddressViews.Clear();
            foreach (var addressView in temp)
            {
                AddressViews.Add(addressView);
            }
        }
        
        
    }
}


