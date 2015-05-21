using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace mLearning.Views
{
    public partial class SignUpPage : ContentPage
    {
        public bool flag = false;

        public SignUpPage()
        {
            InitializeComponent();

        }
        
        async void OnTapGestureRecognizerTappedPhoto(object sender, EventArgs args)
        {

            var action = await DisplayActionSheet("Elegir imagen de perfil de:", "Cancel", null, "Biblioteca", "Camara");

        }
         
        void OnTapGestureRecognizerTappedCheckBox(object sender, EventArgs args)
        {
            if (!flag)
            {
                CheckBoxImage.Source = "checkbox_image_on.png";
                flag = true;
            }
            else
            {
                CheckBoxImage.Source = "checkbox_image_off.png";
                flag = false;
            }
        }

        async void OnTapGestureRecognizerEnterButton(object sender, EventArgs args)
        {
            await Navigation.PushModalAsync(new MasterDetailMainPage());
        }
        
    }
}
