// ALLOWOVERWRITE-11C8E43D482E0BB0BF728E88170B2C8E

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
    public class PaymentHistoryEditViewModel : INotifyPropertyChanged
    {
        public PaymentHistoryEditViewModel()
        {
           SaveCommand=new Command( async () => await Save());
           CancelCommand = new Command(async () => await Cancel());
        }

        public ICommand SaveCommand { get; private set; }

        public ICommand CancelCommand { get; private set; }


        public async Task Cancel()
        {
            if (PaymentHistoryView.PaymentHistoryId> 0)
                await Load(PaymentHistoryView.PaymentHistoryId);
            else
                PaymentHistoryView=new PaymentHistoryView();
        }
        public async Task Load(int paymentHistoryId)
        {
            var uv=new PaymentHistoryViews();

            this.PaymentHistoryView = await uv.Get(paymentHistoryId);
        }

        public async Task Save()
        {
        	try
        	{
	            var uv = new PaymentHistoryTransactions();
	
	            if (PaymentHistoryView.PaymentHistoryId > 0)
	            {
	                PaymentHistoryView = await uv.PaymentHistoryUpdate(this.GetPaymentHistoryUpdate());
	            }
	            else
	            {
	                PaymentHistoryView = await uv.PaymentHistoryAdd(this.GetPaymentHistoryAdd());
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

        private PaymentHistoryView _paymentHistoryView = new PaymentHistoryView();

        public PaymentHistoryView PaymentHistoryView
        {
            get
            {
                return _paymentHistoryView;
            }

            set
            {
                this._paymentHistoryView = value;
                OnPropertyChanged("Amount");
                OnPropertyChanged("PaymentDate");
                OnPropertyChanged("PaymentHistoryId");
                OnPropertyChanged("Reference");
                              
            }
        }
        /// <summary>
        /// 
        /// </summary>	
        public decimal  Amount 
        {
            set
            {
                if (PaymentHistoryView.Amount != value)
                {
                    PaymentHistoryView.Amount = value;
                    OnPropertyChanged("Amount");
                }
            }
            get
            {
                return PaymentHistoryView.Amount;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public DateTime  PaymentDate 
        {
            set
            {
                if (PaymentHistoryView.PaymentDate != value)
                {
                    PaymentHistoryView.PaymentDate = value;
                    OnPropertyChanged("PaymentDate");
                }
            }
            get
            {
                return PaymentHistoryView.PaymentDate;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public int  PaymentHistoryId 
        {
            set
            {
                if (PaymentHistoryView.PaymentHistoryId != value)
                {
                    PaymentHistoryView.PaymentHistoryId = value;
                    OnPropertyChanged("PaymentHistoryId");
                }
            }
            get
            {
                return PaymentHistoryView.PaymentHistoryId;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public string  Reference 
        {
            set
            {
                if (PaymentHistoryView.Reference != value)
                {
                    PaymentHistoryView.Reference = value;
                    OnPropertyChanged("Reference");
                }
            }
            get
            {
                return PaymentHistoryView.Reference;
            } 
         } 	    	
    	/// <summary>
        /// Primary Key for Invoices
        /// </summary>	
       
		 public int  InvoiceInvoiceId 
         {
            set
            {
                if (PaymentHistoryView.InvoiceInvoiceId != value)
                {
                    PaymentHistoryView.InvoiceInvoiceId = value;
                    OnPropertyChanged("InvoiceInvoiceId");
                }
            }
            get
            {
                return PaymentHistoryView.InvoiceInvoiceId;
            } 
         } 	    	

        public PaymentHistoryUpdate GetPaymentHistoryUpdate()
        {
            var result = new PaymentHistoryUpdate();

			result.Amount = PaymentHistoryView.Amount;
			result.PaymentDate = PaymentHistoryView.PaymentDate;
			result.PaymentHistoryId = PaymentHistoryView.PaymentHistoryId;
			result.Reference = PaymentHistoryView.Reference;
            return result;
        }

        public PaymentHistoryAdd GetPaymentHistoryAdd()
        {
            var result = new PaymentHistoryAdd();
			result.Amount = PaymentHistoryView.Amount;
			result.PaymentDate = PaymentHistoryView.PaymentDate;
			result.PaymentHistoryId = PaymentHistoryView.PaymentHistoryId;
			result.Reference = PaymentHistoryView.Reference;
         result.InvoiceInvoiceId= PaymentHistoryView.InvoiceInvoiceId; 
            return result;
        }

        public static explicit operator PaymentHistoryEditViewModel(PaymentHistoryView item)
    	{
       	    var result=new PaymentHistoryEditViewModel();    	 
			result.Amount = item.Amount;
			result.PaymentDate = item.PaymentDate;
			result.PaymentHistoryId = item.PaymentHistoryId;
			result.Reference = item.Reference;
        	return result;
       }
    }

}




