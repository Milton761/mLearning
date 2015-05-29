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

        protected override void OnAppearing()
        {
            base.OnAppearing();
            this.Animate("", new Animation(), 0, 0, Easing.Linear, null, null);
         

        }

        protected override void OnDisappearing()
        {
            base.OnDisappearing();
            this.Animate("", new Animation(), 0, 0, Easing.Linear, null, null);
         

        }

        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();
            this.Animate("", new Animation(), 0, 0, Easing.Linear, null, null);
            return true;
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
