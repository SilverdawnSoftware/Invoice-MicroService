// ALLOWOVERWRITE-3E1C34C52E928B9E71F1BDCAF172D694

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

    public class InvoiceEditViewModel : INotifyPropertyChanged
    {


        public InvoiceEditViewModel()
        {
            SaveCommand=new Command( async () => await Save());
            CancelCommand = new Command(async () => await Cancel());
           	
           	ViewInvoiceLinesCommand = new Command(async () => await ViewInvoiceLines());
           	
            
        }

      

        public ICommand SaveCommand { get; private set; }

        public ICommand CancelCommand { get; private set; }


           	
           	
        public ICommand ViewInvoiceLinesCommand { get; private set; }
         
        public async Task ViewInvoiceLines()
        {           
                var invoiceLines = new InvoiceLineIndexViewModel();
                await invoiceLines.GetInvoiceLinesForInvoice(InvoiceId);
                MessagingCenter.Send<InvoiceEditViewModel, InvoiceLineIndexViewModel>(this, "ShowInvoiceLines", invoiceLines);
        }
           	


        public async Task Cancel()
        {
            if (InvoiceView.InvoiceId> 0)
                await Load(InvoiceView.InvoiceId);
            else
                InvoiceView=new InvoiceView();
        }

        public async Task Load(int invoiceId)
        {
            var uv=new InvoiceViews();

            this.InvoiceView = await uv.Get(invoiceId);
        }



        public async Task Save()
        {
        	try
        	{
	            var uv = new InvoiceTransactions();
	
	            if (InvoiceView.InvoiceId > 0)
	            {
	                InvoiceView = await uv.InvoiceUpdate(this.GetInvoiceUpdate());
	            }
	            else
	            {
	                InvoiceView = await uv.InvoiceAdd(this.GetInvoiceAdd());
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


        private InvoiceView _invoiceView = new InvoiceView();

        public InvoiceView InvoiceView
        {
            get
            {
                return _invoiceView;
            }

            set
            {
                this._invoiceView = value;
                OnPropertyChanged("BillngAddress");
                OnPropertyChanged("CreatedDate");
                OnPropertyChanged("DueDate");
                OnPropertyChanged("EmailTo");
                OnPropertyChanged("GrandTotal");
                OnPropertyChanged("InvoiceEmailed");
                OnPropertyChanged("InvoiceId");
                OnPropertyChanged("InvoiceNo");
                OnPropertyChanged("OrderedBy");
                OnPropertyChanged("PaidAmount");
                OnPropertyChanged("PaidDate");
                OnPropertyChanged("PaidTax");
                OnPropertyChanged("PaymentDetails");
                OnPropertyChanged("PurchaseOrderRef");
                OnPropertyChanged("ShippingAddress");
                OnPropertyChanged("SubTotal");
                OnPropertyChanged("Tax");
                OnPropertyChanged("TermsAndConditions ");
                              
            }
        }

		
       	  	 
        /// <summary>
        /// is class
        /// </summary>	
        public int  BillngAddress 
        {
            set
            {
                if (InvoiceView.BillngAddressAddressId != value)
                {
                    InvoiceView.BillngAddressAddressId = value;
                    OnPropertyChanged("BillngAddressAddressId");
                }
            }
            get
            {
                return InvoiceView.BillngAddressAddressId;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public DateTime  CreatedDate 
        {
            set
            {
                if (InvoiceView.CreatedDate != value)
                {
                    InvoiceView.CreatedDate = value;
                    OnPropertyChanged("CreatedDate");
                }
            }
            get
            {
                return InvoiceView.CreatedDate;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public DateTime  DueDate 
        {
            set
            {
                if (InvoiceView.DueDate != value)
                {
                    InvoiceView.DueDate = value;
                    OnPropertyChanged("DueDate");
                }
            }
            get
            {
                return InvoiceView.DueDate;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  EmailTo 
        {
            set
            {
                if (InvoiceView.EmailTo != value)
                {
                    InvoiceView.EmailTo = value;
                    OnPropertyChanged("EmailTo");
                }
            }
            get
            {
                return InvoiceView.EmailTo;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public decimal  GrandTotal 
        {
            set
            {
                if (InvoiceView.GrandTotal != value)
                {
                    InvoiceView.GrandTotal = value;
                    OnPropertyChanged("GrandTotal");
                }
            }
            get
            {
                return InvoiceView.GrandTotal;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public bool  InvoiceEmailed 
        {
            set
            {
                if (InvoiceView.InvoiceEmailed != value)
                {
                    InvoiceView.InvoiceEmailed = value;
                    OnPropertyChanged("InvoiceEmailed");
                }
            }
            get
            {
                return InvoiceView.InvoiceEmailed;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public int  InvoiceId 
        {
            set
            {
                if (InvoiceView.InvoiceId != value)
                {
                    InvoiceView.InvoiceId = value;
                    OnPropertyChanged("InvoiceId");
                }
            }
            get
            {
                return InvoiceView.InvoiceId;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public int  InvoiceNo 
        {
            set
            {
                if (InvoiceView.InvoiceNo != value)
                {
                    InvoiceView.InvoiceNo = value;
                    OnPropertyChanged("InvoiceNo");
                }
            }
            get
            {
                return InvoiceView.InvoiceNo;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  OrderedBy 
        {
            set
            {
                if (InvoiceView.OrderedBy != value)
                {
                    InvoiceView.OrderedBy = value;
                    OnPropertyChanged("OrderedBy");
                }
            }
            get
            {
                return InvoiceView.OrderedBy;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public double  PaidAmount 
        {
            set
            {
                if (InvoiceView.PaidAmount != value)
                {
                    InvoiceView.PaidAmount = value;
                    OnPropertyChanged("PaidAmount");
                }
            }
            get
            {
                return InvoiceView.PaidAmount;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public DateTime  PaidDate 
        {
            set
            {
                if (InvoiceView.PaidDate != value)
                {
                    InvoiceView.PaidDate = value;
                    OnPropertyChanged("PaidDate");
                }
            }
            get
            {
                return InvoiceView.PaidDate;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public double  PaidTax 
        {
            set
            {
                if (InvoiceView.PaidTax != value)
                {
                    InvoiceView.PaidTax = value;
                    OnPropertyChanged("PaidTax");
                }
            }
            get
            {
                return InvoiceView.PaidTax;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  PaymentDetails 
        {
            set
            {
                if (InvoiceView.PaymentDetails != value)
                {
                    InvoiceView.PaymentDetails = value;
                    OnPropertyChanged("PaymentDetails");
                }
            }
            get
            {
                return InvoiceView.PaymentDetails;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  PurchaseOrderRef 
        {
            set
            {
                if (InvoiceView.PurchaseOrderRef != value)
                {
                    InvoiceView.PurchaseOrderRef = value;
                    OnPropertyChanged("PurchaseOrderRef");
                }
            }
            get
            {
                return InvoiceView.PurchaseOrderRef;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  ShippingAddress 
        {
            set
            {
                if (InvoiceView.ShippingAddress != value)
                {
                    InvoiceView.ShippingAddress = value;
                    OnPropertyChanged("ShippingAddress");
                }
            }
            get
            {
                return InvoiceView.ShippingAddress;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public decimal  SubTotal 
        {
            set
            {
                if (InvoiceView.SubTotal != value)
                {
                    InvoiceView.SubTotal = value;
                    OnPropertyChanged("SubTotal");
                }
            }
            get
            {
                return InvoiceView.SubTotal;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public decimal  Tax 
        {
            set
            {
                if (InvoiceView.Tax != value)
                {
                    InvoiceView.Tax = value;
                    OnPropertyChanged("Tax");
                }
            }
            get
            {
                return InvoiceView.Tax;
            } 
         } 	    	
	    	
       	 
        /// <summary>
        /// 
        /// </summary>	
        public string  TermsAndConditions  
        {
            set
            {
                if (InvoiceView.TermsAndConditions  != value)
                {
                    InvoiceView.TermsAndConditions  = value;
                    OnPropertyChanged("TermsAndConditions ");
                }
            }
            get
            {
                return InvoiceView.TermsAndConditions ;
            } 
         } 	    	
	    	
	    	
    	
    	/// <summary>
        /// 
        /// </summary>	
       
		 public int  CustomerCustomerId 
         {
            set
            {
                if (InvoiceView.CustomerCustomerId != value)
                {
                    InvoiceView.CustomerCustomerId = value;
                    OnPropertyChanged("CustomerCustomerId");
                }
            }
            get
            {
                return InvoiceView.CustomerCustomerId;
            } 
         } 	    	
		
	    	
	    	

      

        public InvoiceUpdate GetInvoiceUpdate()
        {
            var result = new InvoiceUpdate();

	       result.BillngAddressAddressId = InvoiceView.BillngAddressAddressId;	 	
			result.CreatedDate = InvoiceView.CreatedDate;
			result.DueDate = InvoiceView.DueDate;
			result.EmailTo = InvoiceView.EmailTo;
			result.GrandTotal = InvoiceView.GrandTotal;
			result.InvoiceEmailed = InvoiceView.InvoiceEmailed;
			result.InvoiceId = InvoiceView.InvoiceId;
			result.InvoiceNo = InvoiceView.InvoiceNo;
			result.OrderedBy = InvoiceView.OrderedBy;
			result.PaidAmount = InvoiceView.PaidAmount;
			result.PaidDate = InvoiceView.PaidDate;
			result.PaidTax = InvoiceView.PaidTax;
			result.PaymentDetails = InvoiceView.PaymentDetails;
			result.PurchaseOrderRef = InvoiceView.PurchaseOrderRef;
			result.ShippingAddress = InvoiceView.ShippingAddress;
			result.SubTotal = InvoiceView.SubTotal;
			result.Tax = InvoiceView.Tax;
			result.TermsAndConditions  = InvoiceView.TermsAndConditions ;
            return result;
        }

        public InvoiceAdd GetInvoiceAdd()
        {
            var result = new InvoiceAdd();

	       result.BillngAddressAddressId = InvoiceView.BillngAddressAddressId;	 	
			result.CreatedDate = InvoiceView.CreatedDate;
			result.DueDate = InvoiceView.DueDate;
			result.EmailTo = InvoiceView.EmailTo;
			result.GrandTotal = InvoiceView.GrandTotal;
			result.InvoiceEmailed = InvoiceView.InvoiceEmailed;
			result.InvoiceId = InvoiceView.InvoiceId;
			result.InvoiceNo = InvoiceView.InvoiceNo;
			result.OrderedBy = InvoiceView.OrderedBy;
			result.PaidAmount = InvoiceView.PaidAmount;
			result.PaidDate = InvoiceView.PaidDate;
			result.PaidTax = InvoiceView.PaidTax;
			result.PaymentDetails = InvoiceView.PaymentDetails;
			result.PurchaseOrderRef = InvoiceView.PurchaseOrderRef;
			result.ShippingAddress = InvoiceView.ShippingAddress;
			result.SubTotal = InvoiceView.SubTotal;
			result.Tax = InvoiceView.Tax;
			result.TermsAndConditions  = InvoiceView.TermsAndConditions ;
            result.CustomerCustomerId= InvoiceView.CustomerCustomerId; 
            return result;
        }




        public static explicit operator InvoiceEditViewModel(InvoiceView item)
    	{
       	    var result=new InvoiceEditViewModel();
    	 
			result.CreatedDate = item.CreatedDate;
			result.DueDate = item.DueDate;
			result.EmailTo = item.EmailTo;
			result.GrandTotal = item.GrandTotal;
			result.InvoiceEmailed = item.InvoiceEmailed;
			result.InvoiceId = item.InvoiceId;
			result.InvoiceNo = item.InvoiceNo;
			result.OrderedBy = item.OrderedBy;
			result.PaidAmount = item.PaidAmount;
			result.PaidDate = item.PaidDate;
			result.PaidTax = item.PaidTax;
			result.PaymentDetails = item.PaymentDetails;
			result.PurchaseOrderRef = item.PurchaseOrderRef;
			result.ShippingAddress = item.ShippingAddress;
			result.SubTotal = item.SubTotal;
			result.Tax = item.Tax;
			result.TermsAndConditions  = item.TermsAndConditions ;
	    	
        	return result;
       }

     
    }
}




