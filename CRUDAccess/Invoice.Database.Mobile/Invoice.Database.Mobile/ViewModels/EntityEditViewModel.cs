// ALLOWOVERWRITE-2F1F272ED573030E9928A4D28FB2B597-BA458DE1174D4A73EF4D6AC57FB3CDC9

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
    public class EntityEditViewModel : INotifyPropertyChanged
    {
        public EntityEditViewModel()
        {
           SaveCommand=new Command( async () => await Save());
           CancelCommand = new Command(async () => await Cancel());
           ViewCustomersCommand = new Command(async () => await ViewCustomers());
        }

        public ICommand SaveCommand { get; private set; }

        public ICommand CancelCommand { get; private set; }


        public ICommand ViewCustomersCommand { get; private set; }
         
        public async Task ViewCustomers()
        {           
                var customers = new CustomerIndexViewModel();
                await customers.GetCustomersForEntity(EntityId);
                MessagingCenter.Send<EntityEditViewModel, CustomerIndexViewModel>(this, "ShowCustomers", customers);
        }

        public async Task Cancel()
        {
            if (EntityView.EntityId> 0)
                await Load(EntityView.EntityId);
            else
                EntityView=new EntityView();
        }
        public async Task Load(int entityId)
        {
            var uv=new EntityViews();

            this.EntityView = await uv.Get(entityId);
        }

        public async Task Save()
        {
        	try
        	{
	            var uv = new EntityTransactions();
	
	            if (EntityView.EntityId > 0)
	            {
	                EntityView = await uv.EntityUpdate(this.GetEntityUpdate());
	            }
	            else
	            {
	                EntityView = await uv.EntityAdd(this.GetEntityAdd());
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

        private EntityView _entityView = new EntityView();

        public EntityView EntityView
        {
            get
            {
                return _entityView;
            }

            set
            {
                this._entityView = value;
                OnPropertyChanged("Address");
                OnPropertyChanged("EntityExternalRef");
                OnPropertyChanged("EntityId");
                OnPropertyChanged("LogoURL");
                OnPropertyChanged("Name");
                OnPropertyChanged("SMTPEmailDisplayName");
                OnPropertyChanged("SMTPEmailFromAddress");
                OnPropertyChanged("SMTPHost");
                OnPropertyChanged("SMTPPassword");
                OnPropertyChanged("SMTPUserName");
                              
            }
        }
        /// <summary>
        /// 
        /// </summary>	
        public string  EntityExternalRef 
        {
            set
            {
                if (EntityView.EntityExternalRef != value)
                {
                    EntityView.EntityExternalRef = value;
                    OnPropertyChanged("EntityExternalRef");
                }
            }
            get
            {
                return EntityView.EntityExternalRef;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public int  EntityId 
        {
            set
            {
                if (EntityView.EntityId != value)
                {
                    EntityView.EntityId = value;
                    OnPropertyChanged("EntityId");
                }
            }
            get
            {
                return EntityView.EntityId;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public string  LogoURL 
        {
            set
            {
                if (EntityView.LogoURL != value)
                {
                    EntityView.LogoURL = value;
                    OnPropertyChanged("LogoURL");
                }
            }
            get
            {
                return EntityView.LogoURL;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public string  Name 
        {
            set
            {
                if (EntityView.Name != value)
                {
                    EntityView.Name = value;
                    OnPropertyChanged("Name");
                }
            }
            get
            {
                return EntityView.Name;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public string  SMTPEmailDisplayName 
        {
            set
            {
                if (EntityView.SMTPEmailDisplayName != value)
                {
                    EntityView.SMTPEmailDisplayName = value;
                    OnPropertyChanged("SMTPEmailDisplayName");
                }
            }
            get
            {
                return EntityView.SMTPEmailDisplayName;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public string  SMTPEmailFromAddress 
        {
            set
            {
                if (EntityView.SMTPEmailFromAddress != value)
                {
                    EntityView.SMTPEmailFromAddress = value;
                    OnPropertyChanged("SMTPEmailFromAddress");
                }
            }
            get
            {
                return EntityView.SMTPEmailFromAddress;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public string  SMTPHost 
        {
            set
            {
                if (EntityView.SMTPHost != value)
                {
                    EntityView.SMTPHost = value;
                    OnPropertyChanged("SMTPHost");
                }
            }
            get
            {
                return EntityView.SMTPHost;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public string  SMTPPassword 
        {
            set
            {
                if (EntityView.SMTPPassword != value)
                {
                    EntityView.SMTPPassword = value;
                    OnPropertyChanged("SMTPPassword");
                }
            }
            get
            {
                return EntityView.SMTPPassword;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public string  SMTPUserName 
        {
            set
            {
                if (EntityView.SMTPUserName != value)
                {
                    EntityView.SMTPUserName = value;
                    OnPropertyChanged("SMTPUserName");
                }
            }
            get
            {
                return EntityView.SMTPUserName;
            } 
         } 	    	

        public EntityUpdate GetEntityUpdate()
        {
            var result = new EntityUpdate();

			result.EntityExternalRef = EntityView.EntityExternalRef;
			result.EntityId = EntityView.EntityId;
			result.LogoURL = EntityView.LogoURL;
			result.Name = EntityView.Name;
			result.SMTPEmailDisplayName = EntityView.SMTPEmailDisplayName;
			result.SMTPEmailFromAddress = EntityView.SMTPEmailFromAddress;
			result.SMTPHost = EntityView.SMTPHost;
			result.SMTPPassword = EntityView.SMTPPassword;
			result.SMTPUserName = EntityView.SMTPUserName;
            return result;
        }

        public EntityAdd GetEntityAdd()
        {
            var result = new EntityAdd();
			result.EntityExternalRef = EntityView.EntityExternalRef;
			result.EntityId = EntityView.EntityId;
			result.LogoURL = EntityView.LogoURL;
			result.Name = EntityView.Name;
			result.SMTPEmailDisplayName = EntityView.SMTPEmailDisplayName;
			result.SMTPEmailFromAddress = EntityView.SMTPEmailFromAddress;
			result.SMTPHost = EntityView.SMTPHost;
			result.SMTPPassword = EntityView.SMTPPassword;
			result.SMTPUserName = EntityView.SMTPUserName;
            return result;
        }

        public static explicit operator EntityEditViewModel(EntityView item)
    	{
       	    var result=new EntityEditViewModel();    	 
	     //  result.Address = item.Address; 	
			result.EntityExternalRef = item.EntityExternalRef;
			result.EntityId = item.EntityId;
			result.LogoURL = item.LogoURL;
			result.Name = item.Name;
			result.SMTPEmailDisplayName = item.SMTPEmailDisplayName;
			result.SMTPEmailFromAddress = item.SMTPEmailFromAddress;
			result.SMTPHost = item.SMTPHost;
			result.SMTPPassword = item.SMTPPassword;
			result.SMTPUserName = item.SMTPUserName;
        	return result;
       }
    }

}




