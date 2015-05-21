using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace mLearning.Views
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        async void OnTapGestureRecognizerEnterButton(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new MasterDetailMainPage());
        }

        async void OnButtonClicked_SignUp(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new SignUpPage());
        }
    }
}
