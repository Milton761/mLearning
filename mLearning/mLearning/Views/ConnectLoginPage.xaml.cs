using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace mLearning.Views
{
    public partial class ConnectLoginPage : ContentPage
    {
        public ConnectLoginPage()
        {
            InitializeComponent();

            

        }

        async void OnButtonClicked_Login(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new LoginPage());
        }

        async void OnButtonClicked_SignUp(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new SignUpPage());
        }
    }
}
