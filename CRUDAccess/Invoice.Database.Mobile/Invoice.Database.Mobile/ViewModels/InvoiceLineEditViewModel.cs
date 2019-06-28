// ALLOWOVERWRITE-970B331EC6727278666DE9EE68590A04-C623E401E5629DCE2B52FC67FE6A9D2D

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
    public class InvoiceLineEditViewModel : INotifyPropertyChanged
    {
        public InvoiceLineEditViewModel()
        {
           SaveCommand=new Command( async () => await Save());
           CancelCommand = new Command(async () => await Cancel());
        }

        public ICommand SaveCommand { get; private set; }

        public ICommand CancelCommand { get; private set; }


        public async Task Cancel()
        {
            if (InvoiceLineView.InvoiceLineId> 0)
                await Load(InvoiceLineView.InvoiceLineId);
            else
                InvoiceLineView=new InvoiceLineView();
        }
        public async Task Load(int invoiceLineId)
        {
            var uv=new InvoiceLineViews();

            this.InvoiceLineView = await uv.Get(invoiceLineId);
        }

        public async Task Save()
        {
        	try
        	{
	            var uv = new InvoiceLineTransactions();
	
	            if (InvoiceLineView.InvoiceLineId > 0)
	            {
	                InvoiceLineView = await uv.InvoiceLineUpdate(this.GetInvoiceLineUpdate());
	            }
	            else
	            {
	                InvoiceLineView = await uv.InvoiceLineAdd(this.GetInvoiceLineAdd());
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

        private InvoiceLineView _invoiceLineView = new InvoiceLineView();

        public InvoiceLineView InvoiceLineView
        {
            get
            {
                return _invoiceLineView;
            }

            set
            {
                this._invoiceLineView = value;
                OnPropertyChanged("InvoiceLineId");
                OnPropertyChanged("LineTotal");
                OnPropertyChanged("Notes");
                OnPropertyChanged("Product");
                OnPropertyChanged("ProductCode");
                OnPropertyChanged("Quantity");
                OnPropertyChanged("SubTotal");
                OnPropertyChanged("TaxExempt");
                OnPropertyChanged("TaxTotal");
                OnPropertyChanged("UnitCost");
                              
            }
        }
        /// <summary>
        /// 
        /// </summary>	
        public int  InvoiceLineId 
        {
            set
            {
                if (InvoiceLineView.InvoiceLineId != value)
                {
                    InvoiceLineView.InvoiceLineId = value;
                    OnPropertyChanged("InvoiceLineId");
                }
            }
            get
            {
                return InvoiceLineView.InvoiceLineId;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public decimal  LineTotal 
        {
            set
            {
                if (InvoiceLineView.LineTotal != value)
                {
                    InvoiceLineView.LineTotal = value;
                    OnPropertyChanged("LineTotal");
                }
            }
            get
            {
                return InvoiceLineView.LineTotal;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public string  Notes 
        {
            set
            {
                if (InvoiceLineView.Notes != value)
                {
                    InvoiceLineView.Notes = value;
                    OnPropertyChanged("Notes");
                }
            }
            get
            {
                return InvoiceLineView.Notes;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public string  Product 
        {
            set
            {
                if (InvoiceLineView.Product != value)
                {
                    InvoiceLineView.Product = value;
                    OnPropertyChanged("Product");
                }
            }
            get
            {
                return InvoiceLineView.Product;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public string  ProductCode 
        {
            set
            {
                if (InvoiceLineView.ProductCode != value)
                {
                    InvoiceLineView.ProductCode = value;
                    OnPropertyChanged("ProductCode");
                }
            }
            get
            {
                return InvoiceLineView.ProductCode;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public double  Quantity 
        {
            set
            {
                if (InvoiceLineView.Quantity != value)
                {
                    InvoiceLineView.Quantity = value;
                    OnPropertyChanged("Quantity");
                }
            }
            get
            {
                return InvoiceLineView.Quantity;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public decimal  SubTotal 
        {
            set
            {
                if (InvoiceLineView.SubTotal != value)
                {
                    InvoiceLineView.SubTotal = value;
                    OnPropertyChanged("SubTotal");
                }
            }
            get
            {
                return InvoiceLineView.SubTotal;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public bool  TaxExempt 
        {
            set
            {
                if (InvoiceLineView.TaxExempt != value)
                {
                    InvoiceLineView.TaxExempt = value;
                    OnPropertyChanged("TaxExempt");
                }
            }
            get
            {
                return InvoiceLineView.TaxExempt;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public decimal  TaxTotal 
        {
            set
            {
                if (InvoiceLineView.TaxTotal != value)
                {
                    InvoiceLineView.TaxTotal = value;
                    OnPropertyChanged("TaxTotal");
                }
            }
            get
            {
                return InvoiceLineView.TaxTotal;
            } 
         } 	    	
        /// <summary>
        /// 
        /// </summary>	
        public decimal  UnitCost 
        {
            set
            {
                if (InvoiceLineView.UnitCost != value)
                {
                    InvoiceLineView.UnitCost = value;
                    OnPropertyChanged("UnitCost");
                }
            }
            get
            {
                return InvoiceLineView.UnitCost;
            } 
         } 	    	
    	/// <summary>
        /// Primary Key for Invoices
        /// </summary>	
       
		 public int  InvoiceInvoiceId 
         {
            set
            {
                if (InvoiceLineView.InvoiceInvoiceId != value)
                {
                    InvoiceLineView.InvoiceInvoiceId = value;
                    OnPropertyChanged("InvoiceInvoiceId");
                }
            }
            get
            {
                return InvoiceLineView.InvoiceInvoiceId;
            } 
         } 	    	

        public InvoiceLineUpdate GetInvoiceLineUpdate()
        {
            var result = new InvoiceLineUpdate();

			result.InvoiceLineId = InvoiceLineView.InvoiceLineId;
			result.LineTotal = InvoiceLineView.LineTotal;
			result.Notes = InvoiceLineView.Notes;
			result.Product = InvoiceLineView.Product;
			result.ProductCode = InvoiceLineView.ProductCode;
			result.Quantity = InvoiceLineView.Quantity;
			result.SubTotal = InvoiceLineView.SubTotal;
			result.TaxExempt = InvoiceLineView.TaxExempt;
			result.TaxTotal = InvoiceLineView.TaxTotal;
			result.UnitCost = InvoiceLineView.UnitCost;
            return result;
        }

        public InvoiceLineAdd GetInvoiceLineAdd()
        {
            var result = new InvoiceLineAdd();
			result.InvoiceLineId = InvoiceLineView.InvoiceLineId;
			result.LineTotal = InvoiceLineView.LineTotal;
			result.Notes = InvoiceLineView.Notes;
			result.Product = InvoiceLineView.Product;
			result.ProductCode = InvoiceLineView.ProductCode;
			result.Quantity = InvoiceLineView.Quantity;
			result.SubTotal = InvoiceLineView.SubTotal;
			result.TaxExempt = InvoiceLineView.TaxExempt;
			result.TaxTotal = InvoiceLineView.TaxTotal;
			result.UnitCost = InvoiceLineView.UnitCost;
         result.InvoiceInvoiceId= InvoiceLineView.InvoiceInvoiceId; 
            return result;
        }

        public static explicit operator InvoiceLineEditViewModel(InvoiceLineView item)
    	{
       	    var result=new InvoiceLineEditViewModel();    	 
			result.InvoiceLineId = item.InvoiceLineId;
			result.LineTotal = item.LineTotal;
			result.Notes = item.Notes;
			result.Product = item.Product;
			result.ProductCode = item.ProductCode;
			result.Quantity = item.Quantity;
			result.SubTotal = item.SubTotal;
			result.TaxExempt = item.TaxExempt;
			result.TaxTotal = item.TaxTotal;
			result.UnitCost = item.UnitCost;
        	return result;
       }
    }

}




