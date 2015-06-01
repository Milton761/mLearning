using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin;
using Xamarin.Forms;


namespace mLearning.Views
{
    public partial class ConnectLoginPage : ContentPage
    {
        
        public ConnectLoginPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {

            Insights.Track("ConnectedLogiPage Appearing");
            base.OnAppearing();
            this.Animate("",new Animation(),0,0, Easing.Linear, null, null);
            _LogoEdutic.RotateTo(90);
            
        }

        protected override void OnDisappearing()
        {
            Insights.Track("ConnectedLogiPage Disappearing");
            base.OnDisappearing();
            this.Animate("",new Animation(),0,0, Easing.Linear, null, null);
            _LogoEdutic.RotateTo(-90);
            
        }

        protected override bool OnBackButtonPressed()
        {
            base.OnBackButtonPressed();
            this.Animate("", new Animation(), 0, 0, Easing.Linear, null, null);
            return true;
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
