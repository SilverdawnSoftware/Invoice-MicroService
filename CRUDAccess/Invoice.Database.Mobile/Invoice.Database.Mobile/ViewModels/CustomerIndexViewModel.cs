// ALLOWOVERWRITE-38358BF49F41723853CE05A0DECAC6E1

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
    public class CustomerIndexViewModel : INotifyPropertyChanged
    {


		 public ICommand AddCustomerCommand { get; private set; }

        public CustomerIndexViewModel()
        {
            AddCustomerCommand = new Command(async () => await AddCustomer());
        }

        private async Task AddCustomer()
        {
            var customer=new CustomerEditViewModel();

 			customer.EntityEntityId= EntityEntityId; 
            MessagingCenter.Send<CustomerIndexViewModel, CustomerEditViewModel>(this, "AddCustomer", customer);
        }

 		public int EntityEntityId {get; set;} 


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<CustomerView> CustomerViews { get; set; } = new ObservableCollection<CustomerView>();

		
        public async System.Threading.Tasks.Task GetCustomersForEntity(int entityEntityId)
        {
        	EntityEntityId=entityEntityId;
            var Customers = new CustomerViews();
            var temp = await Customers.GetAllForEntity(entityEntityId);
            CustomerViews.Clear();
            foreach (var customerView in temp)
            {
                CustomerViews.Add(customerView);
            }
        }
        
        
    }
}


