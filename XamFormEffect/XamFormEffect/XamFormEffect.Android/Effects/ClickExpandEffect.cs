using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using XamFormEffect.Droid.Effects;

[assembly:ExportEffect(typeof(ClickExpandEffect), "ClickExpandEffect")]
namespace XamFormEffect.Droid.Effects
{
    public class ClickExpandEffect : PlatformEffect
    {
        protected override void OnAttached()
        {
            
        }

        protected override void OnDetached()
        {
            
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            if(args.PropertyName == "Enable")
            {
                Control.Visibility = ViewStates.Invisible;

            }
        }
    }
}