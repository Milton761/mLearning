﻿using Microsoft.Phone.Controls;
using mLearning;
using mLearning.CustomRenders;
using mLearning.WinPhone;
using mLearning.WinPhone.CustomRenders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using Xamarin.Forms;
using Xamarin.Forms.Platform.WinPhone;



[assembly: ExportRenderer(typeof(CustomEntry), typeof(CustomEntryRenderer))]

namespace mLearning.WinPhone.CustomRenders
{
    class CustomEntryRenderer : EntryRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Entry> e)
        {
            base.OnElementChanged(e);

            if (e.OldElement == null)
            {
                var nativePhoneTextBox = (PhoneTextBox)Control.Children[0];
                //var nativePasswordBox = (PhoneTextBox)Control.Children[1]; // modify if you're using IsPassword=true in Xamarin.Forms code
                nativePhoneTextBox.Background = new SolidColorBrush(Colors.Transparent);
                nativePhoneTextBox.BorderBrush = new SolidColorBrush(Colors.Transparent);
            }
        }


    }
}
