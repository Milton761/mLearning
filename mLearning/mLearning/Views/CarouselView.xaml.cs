using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs.Forms.Controls;
using XLabs.Forms.Mvvm;
using mLearning.Views;
using mLearning.Data;


namespace mLearning.Views
{
    public partial class CarouselView : ContentPage
    {
        public CarouselView()
        {

            InitializeComponent();

            var SourceListView = new ObservableCollection<ListViewDataExample>{
                new ListViewDataExample {ImageUri="selected_listview_off.png",ItemText="Camino Inca"},
                new ListViewDataExample {ImageUri="selected_listview_off.png",ItemText="Aprendizaje"},
                new ListViewDataExample {ImageUri="selected_listview_off.png",ItemText="Animales"},
                new ListViewDataExample {ImageUri="selected_listview_off.png",ItemText="Programación"},
                new ListViewDataExample {ImageUri="selected_listview_off.png",ItemText="New Office"},
                new ListViewDataExample {ImageUri="selected_listview_off.png",ItemText="Like IT"}
            };

            var SourceComentListView = new ComentsDataExample[]{
                new ComentsDataExample {ImageUri="user200.png",Name="Alicia Smith", Date="1:25 p.m" , Coment="Esto es un comentario"},
                new ComentsDataExample {ImageUri="user200.png",Name="Jason Jugens", Date="1:25 p.m" , Coment="Esto es un comentario mas largo"},
                
            };

            
            var SourceListViewProfiles = new ProfileDataExample[]{
                new ProfileDataExample {ImageUri="user200.png"},
                new ProfileDataExample {ImageUri="user200.png"},
                new ProfileDataExample {ImageUri="user200.png"},
                new ProfileDataExample {ImageUri="user200.png"},
                new ProfileDataExample {ImageUri="user200.png"},
                new ProfileDataExample {ImageUri="user200.png"},
                new ProfileDataExample {ImageUri="user200.png"},
                new ProfileDataExample {ImageUri="user200.png"},
                new ProfileDataExample {ImageUri="user200.png"},
                new ProfileDataExample {ImageUri="user200.png"},
                new ProfileDataExample {ImageUri="user200.png"},
                new ProfileDataExample {ImageUri="user200.png"},
                new ProfileDataExample {ImageUri="user200.png"}

            };

            listview_profiles.ItemsSource = SourceListViewProfiles;

            carousel_view.ViewModels = SourceListView;
            carousel_view.TemplateSelector = cselect;

            comentsListView.ItemsSource = SourceComentListView;
            
           
        }
        
    }
}
