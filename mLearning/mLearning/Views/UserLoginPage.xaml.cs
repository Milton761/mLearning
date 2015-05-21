using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace mLearning.Views
{
    public partial class UserLoginPage : ContentPage
    {
        public UserLoginPage()
        {
            InitializeComponent();
        }

        async void OnTapGestureRecognizerEnterButton(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new MasterDetailMainPage());
        }
    }


    
}
