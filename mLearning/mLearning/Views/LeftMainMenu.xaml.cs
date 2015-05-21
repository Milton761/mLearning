using mLearning.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace mLearning.Views
{
    public partial class LeftMainMenu : ContentPage
    {
        public LeftMainMenu()
        {


            InitializeComponent();


            var SourceListView = new ListViewDataExample[]{
                new ListViewDataExample {ImageUri="selected_listview_off.png",ItemText="Camino Inca"},
                new ListViewDataExample {ImageUri="selected_listview_off.png",ItemText="Aprendizaje"},
                new ListViewDataExample {ImageUri="selected_listview_off.png",ItemText="Animales"},
                new ListViewDataExample {ImageUri="selected_listview_off.png",ItemText="Programación"},
                new ListViewDataExample {ImageUri="selected_listview_off.png",ItemText="New Office"},
                new ListViewDataExample {ImageUri="selected_listview_off.png",ItemText="Like IT"}
            };

            var SourceListViewEndButtons = new ListViewDataExample[]{
                new ListViewDataExample {ImageUri="settings_listview.png",ItemText="Settings"},
                new ListViewDataExample {ImageUri="log_out.png",ItemText="Log out"}
            };

            itemListView.ItemsSource = SourceListView;
            itemListViewEndButtons.ItemsSource = SourceListViewEndButtons;

        }
    }
}
