// ALLOWOVERWRITE-58050F27285B570FF195D95680CEB52C

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
    public class EntityIndexViewModel : INotifyPropertyChanged
    {


		 public ICommand AddEntityCommand { get; private set; }

        public EntityIndexViewModel()
        {
            AddEntityCommand = new Command(async () => await AddEntity());
        }

        private async Task AddEntity()
        {
            var entity=new EntityEditViewModel();

            MessagingCenter.Send<EntityIndexViewModel, EntityEditViewModel>(this, "AddEntity", entity);
        }



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public ObservableCollection<EntityView> EntityViews { get; set; } = new ObservableCollection<EntityView>();

        
        public async System.Threading.Tasks.Task GetEntitys()
        {
            var Entitys = new EntityViews();

            var temp = await Entitys.GetAll();

            //Items.Add(temp.First());

            EntityViews.Clear();

            foreach (var entityView in temp)
            {
                EntityViews.Add(entityView);
            }
        }
        
        
        
    }
}


