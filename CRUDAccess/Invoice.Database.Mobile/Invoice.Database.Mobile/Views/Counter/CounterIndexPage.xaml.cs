// ALLOWOVERWRITE-A0928541CF5EC828E340B0801BB62725

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

namespace Database.Mobile.Views.Counter
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CounterIndexPage : ContentPage
    {
        public ObservableCollection<CounterView> Items { get; set; }=new ObservableCollection<CounterView>();

        public CounterIndexPage()
        {
            InitializeComponent();
			       
        }
        
        
        

        
    }

}


