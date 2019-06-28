// ALLOWOVERWRITE-89DF03E0E2EA04DAB3A95421B0D51123-DE0B986555663E8FCA9323EF280B2592

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
    public class CustomerEditViewModel : INotifyPropertyChanged
    {
        public CustomerEditViewModel()
        {
           SaveCommand=new Command( async () => await Save());
           CancelCommand = new Command(async () => await Cancel());
           ViewInvoicesCommand = new Command(async () => await ViewInvoices());
        }

        public ICommand SaveCommand { get; private set; }

        public ICommand CancelCommand { get; private set; }


        public ICommand ViewInvoicesCommand { get; private set; }
         
        public async Task ViewInvoices()
        {           
                var invoices = new InvoiceIndexViewModel();
                await invoices.GetInvoicesForCustomer(CustomerId);
                MessagingCenter.Send<CustomerEditViewModel, InvoiceIndexViewModel>(this, "ShowInvoices", invoices);
        }

        public async Task Cancel()
        {
            if (CustomerView.CustomerId> 0)
                await Load(CustomerView.CustomerId);
            else
                CustomerView=new CustomerView();
        }
        public async Task Load(int customerId)
        {
            var uv=new CustomerViews();

            this.CustomerView = await uv.Get(customerId);
        }

        public async Task Save()
        {
        	try
        	{
	            var uv = new CustomerTransactions();
	
	            if (CustomerView.CustomerId > 0)
	            {
	                CustomerView = await uv.CustomerUpdate(this.GetCustomerUpdate());
	            }
	            else
	            {
	                CustomerView = await uv.CustomerAdd(this.GetCustomerAdd());
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

        private CustomerView _customerView = new CustomerView();

        public CustomerView CustomerView
        {
            get
            {
                return _customerView;
            }

            set
            {
                this._customerView = value;
                OnPropertyChanged("Active");
                OnPropertyChanged("Address");
                OnPropertyChanged("CustomerExteranlRef");
                OnPropertyChanged("CustomerId");
                OnPropertyChanged("EmailAddress");
                OnPropertyChanged("IsCompany");
                OnPropertyChanged("Name");
                OnPropertyChanged("PhoneNumber");
                OnPropertyChanged("TaxNo");
                              
            }
        }
        /// <summary>
        /// 
        /// </summary>	
        public bool  Active 
        {
            set
            {
                if (CustomerView.Active != value)
                {
                    CustomerView.Active = value;
                    OnPropertyChanged("Active");
                }
            }
            get
            {
                return CustomerView.Active;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public string  CustomerExteranlRef 
        {
            set
            {
                if (CustomerView.CustomerExteranlRef != value)
                {
                    CustomerView.CustomerExteranlRef = value;
                    OnPropertyChanged("CustomerExteranlRef");
                }
            }
            get
            {
                return CustomerView.CustomerExteranlRef;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public int  CustomerId 
        {
            set
            {
                if (CustomerView.CustomerId != value)
                {
                    CustomerView.CustomerId = value;
                    OnPropertyChanged("CustomerId");
                }
            }
            get
            {
                return CustomerView.CustomerId;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public string  EmailAddress 
        {
            set
            {
                if (CustomerView.EmailAddress != value)
                {
                    CustomerView.EmailAddress = value;
                    OnPropertyChanged("EmailAddress");
                }
            }
            get
            {
                return CustomerView.EmailAddress;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public bool  IsCompany 
        {
            set
            {
                if (CustomerView.IsCompany != value)
                {
                    CustomerView.IsCompany = value;
                    OnPropertyChanged("IsCompany");
                }
            }
            get
            {
                return CustomerView.IsCompany;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public string  Name 
        {
            set
            {
                if (CustomerView.Name != value)
                {
                    CustomerView.Name = value;
                    OnPropertyChanged("Name");
                }
            }
            get
            {
                return CustomerView.Name;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public string  PhoneNumber 
        {
            set
            {
                if (CustomerView.PhoneNumber != value)
                {
                    CustomerView.PhoneNumber = value;
                    OnPropertyChanged("PhoneNumber");
                }
            }
            get
            {
                return CustomerView.PhoneNumber;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public string  TaxNo 
        {
            set
            {
                if (CustomerView.TaxNo != value)
                {
                    CustomerView.TaxNo = value;
                    OnPropertyChanged("TaxNo");
                }
            }
            get
            {
                return CustomerView.TaxNo;
            } 
         } 	    	
    	/// <summary>
        /// 
        /// </summary>	
       
		 public int  EntityEntityId 
         {
            set
            {
                if (CustomerView.EntityEntityId != value)
                {
                    CustomerView.EntityEntityId = value;
                    OnPropertyChanged("EntityEntityId");
                }
            }
            get
            {
                return CustomerView.EntityEntityId;
            } 
         } 	    	

        public CustomerUpdate GetCustomerUpdate()
        {
            var result = new CustomerUpdate();

			result.Active = CustomerView.Active;
			result.CustomerExteranlRef = CustomerView.CustomerExteranlRef;
			result.CustomerId = CustomerView.CustomerId;
			result.EmailAddress = CustomerView.EmailAddress;
			result.IsCompany = CustomerView.IsCompany;
			result.Name = CustomerView.Name;
			result.PhoneNumber = CustomerView.PhoneNumber;
			result.TaxNo = CustomerView.TaxNo;
            return result;
        }

        public CustomerAdd GetCustomerAdd()
        {
            var result = new CustomerAdd();
			result.Active = CustomerView.Active;
			result.CustomerExteranlRef = CustomerView.CustomerExteranlRef;
			result.CustomerId = CustomerView.CustomerId;
			result.EmailAddress = CustomerView.EmailAddress;
			result.IsCompany = CustomerView.IsCompany;
			result.Name = CustomerView.Name;
			result.PhoneNumber = CustomerView.PhoneNumber;
			result.TaxNo = CustomerView.TaxNo;
         result.EntityEntityId= CustomerView.EntityEntityId; 
            return result;
        }

        public static explicit operator CustomerEditViewModel(CustomerView item)
    	{
       	    var result=new CustomerEditViewModel();    	 
			result.Active = item.Active;
	     //  result.Address = item.Address; 	
			result.CustomerExteranlRef = item.CustomerExteranlRef;
			result.CustomerId = item.CustomerId;
			result.EmailAddress = item.EmailAddress;
			result.IsCompany = item.IsCompany;
			result.Name = item.Name;
			result.PhoneNumber = item.PhoneNumber;
			result.TaxNo = item.TaxNo;
        	return result;
       }
    }

}




