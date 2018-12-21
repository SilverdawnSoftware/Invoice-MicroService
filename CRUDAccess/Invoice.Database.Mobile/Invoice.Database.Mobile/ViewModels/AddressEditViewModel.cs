// ALLOWOVERWRITE-94C5EC9AAB2E8937E55CEAA1CFADBC9B

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Input;
using Database.Transactions;
using Database.Transactions.Model;
using Database.Views;
using Database.Views.Model;
using Database.Mobile.Annotations;

using Xamarin.Forms;

namespace Database.Mobile.ViewModels
{

    public class AddressEditViewModel : INotifyPropertyChanged
    {


        public AddressEditViewModel()
        {
            SaveCommand=new Command( async () => await Save());
            CancelCommand = new Command(async () => await Cancel());
            
        }

      

        public ICommand SaveCommand { get; private set; }

        public ICommand CancelCommand { get; private set; }




        public async Task Cancel()
        {
            if (AddressView.AddressId> 0)
                await Load(AddressView.AddressId);
            else
                AddressView=new AddressView();
        }

        public async Task Load(int addressId)
        {
            var uv=new AddressViews();

            this.AddressView = await uv.Get(addressId);
        }



        public async Task Save()
        {
        	try
        	{
	            var uv = new AddressTransactions();
	
	            if (AddressView.AddressId > 0)
	            {
	                AddressView = await uv.AddressUpdate(this.GetAddressUpdate());
	            }
	            else
	            {
	                AddressView = await uv.AddressAdd(this.GetAddressAdd());
	            }
            }
            catch (Exception ex)
            {
            	 MessagingCenter.Send(this, "Save error");
            }
          
        }


        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }


        private AddressView _addressView = new AddressView();

        public AddressView AddressView
        {
            get
            {
                return _addressView;
            }

            set
            {
                this._addressView = value;
                OnPropertyChanged("AddresLine2");
                OnPropertyChanged("AddressExternalRef");
                OnPropertyChanged("AddressId");
                OnPropertyChanged("AddressLine1");
                OnPropertyChanged("AddressLine3");
                OnPropertyChanged("City");
                OnPropertyChanged("Country");
                OnPropertyChanged("PostZipCode");
                OnPropertyChanged("StateCounty");
                              
            }
        }

		
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  AddresLine2 
        {
            set
            {
                if (AddressView.AddresLine2 != value)
                {
                    AddressView.AddresLine2 = value;
                    OnPropertyChanged("AddresLine2");
                }
            }
            get
            {
                return AddressView.AddresLine2;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  AddressExternalRef 
        {
            set
            {
                if (AddressView.AddressExternalRef != value)
                {
                    AddressView.AddressExternalRef = value;
                    OnPropertyChanged("AddressExternalRef");
                }
            }
            get
            {
                return AddressView.AddressExternalRef;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public int  AddressId 
        {
            set
            {
                if (AddressView.AddressId != value)
                {
                    AddressView.AddressId = value;
                    OnPropertyChanged("AddressId");
                }
            }
            get
            {
                return AddressView.AddressId;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  AddressLine1 
        {
            set
            {
                if (AddressView.AddressLine1 != value)
                {
                    AddressView.AddressLine1 = value;
                    OnPropertyChanged("AddressLine1");
                }
            }
            get
            {
                return AddressView.AddressLine1;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  AddressLine3 
        {
            set
            {
                if (AddressView.AddressLine3 != value)
                {
                    AddressView.AddressLine3 = value;
                    OnPropertyChanged("AddressLine3");
                }
            }
            get
            {
                return AddressView.AddressLine3;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  City 
        {
            set
            {
                if (AddressView.City != value)
                {
                    AddressView.City = value;
                    OnPropertyChanged("City");
                }
            }
            get
            {
                return AddressView.City;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  Country 
        {
            set
            {
                if (AddressView.Country != value)
                {
                    AddressView.Country = value;
                    OnPropertyChanged("Country");
                }
            }
            get
            {
                return AddressView.Country;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  PostZipCode 
        {
            set
            {
                if (AddressView.PostZipCode != value)
                {
                    AddressView.PostZipCode = value;
                    OnPropertyChanged("PostZipCode");
                }
            }
            get
            {
                return AddressView.PostZipCode;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  StateCounty 
        {
            set
            {
                if (AddressView.StateCounty != value)
                {
                    AddressView.StateCounty = value;
                    OnPropertyChanged("StateCounty");
                }
            }
            get
            {
                return AddressView.StateCounty;
            } 
         } 	    	
	    	
	    	
    	
    	/// <summary>
        /// 
        /// </summary>	
       
		 public int  CustomerCustomerId 
         {
            set
            {
                if (AddressView.CustomerCustomerId != value)
                {
                    AddressView.CustomerCustomerId = value;
                    OnPropertyChanged("CustomerCustomerId");
                }
            }
            get
            {
                return AddressView.CustomerCustomerId;
            } 
         } 	    	
		
	    	
	    	

      

        public AddressUpdate GetAddressUpdate()
        {
            var result = new AddressUpdate();

			result.AddresLine2 = AddressView.AddresLine2;
			result.AddressExternalRef = AddressView.AddressExternalRef;
			result.AddressId = AddressView.AddressId;
			result.AddressLine1 = AddressView.AddressLine1;
			result.AddressLine3 = AddressView.AddressLine3;
			result.City = AddressView.City;
			result.Country = AddressView.Country;
			result.PostZipCode = AddressView.PostZipCode;
			result.StateCounty = AddressView.StateCounty;
            return result;
        }

        public AddressAdd GetAddressAdd()
        {
            var result = new AddressAdd();

			result.AddresLine2 = AddressView.AddresLine2;
			result.AddressExternalRef = AddressView.AddressExternalRef;
			result.AddressId = AddressView.AddressId;
			result.AddressLine1 = AddressView.AddressLine1;
			result.AddressLine3 = AddressView.AddressLine3;
			result.City = AddressView.City;
			result.Country = AddressView.Country;
			result.PostZipCode = AddressView.PostZipCode;
			result.StateCounty = AddressView.StateCounty;
            result.CustomerCustomerId= AddressView.CustomerCustomerId; 
            return result;
        }




        public static explicit operator AddressEditViewModel(AddressView item)
    	{
       	    var result=new AddressEditViewModel();
    	 
			result.AddresLine2 = item.AddresLine2;
			result.AddressExternalRef = item.AddressExternalRef;
			result.AddressId = item.AddressId;
			result.AddressLine1 = item.AddressLine1;
			result.AddressLine3 = item.AddressLine3;
			result.City = item.City;
			result.Country = item.Country;
			result.PostZipCode = item.PostZipCode;
			result.StateCounty = item.StateCounty;
	    	
        	return result;
       }

     
    }
}




