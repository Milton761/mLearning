using mLearning.Views;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Xamarin.Forms;
using XLabs.Forms.Controls;

namespace mLearning
{
    public partial class App : Application
    {

        public NavigationPage root = new NavigationPage();

        public App()
        {
            // The root page of your application
            InitializeComponent();

            //check if user is login
            var isLoggedIn = false;
            /*

            MainPage = new CarouselPage
            {
                Children = {
                    new ConnectLoginPage(),
                    new SignUpPage(),
                    new UserLoginPage(),
                    new LoginPage(),
                    
                }

            };
            */

            //MainPage = new ConnectLoginPage();

            
            
            if (isLoggedIn)
            {
                MainPage = new MasterDetailMainPage();
            }else{
                MainPage = new ConnectLoginPage();
            }
            

        }

        protected override void OnStart()
        {
            Debug.WriteLine("OnStart");
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            Debug.WriteLine("OnSleep");
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            Debug.WriteLine("OnResume");
            // Handle when your app resumes
        }
    }
}
