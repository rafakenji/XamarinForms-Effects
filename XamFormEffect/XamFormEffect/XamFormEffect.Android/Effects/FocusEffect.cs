using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using XamFormEffect.Droid.Effects;
using Xamarin.Forms.Platform.Android;
using System.ComponentModel;

[assembly:ResolutionGroupName("K1IT")]
[assembly:ExportEffect(typeof(FocusEffect), "FocusEffect")]
namespace XamFormEffect.Droid.Effects
{
    public class FocusEffect : PlatformEffect
    {
        private Android.Graphics.Color Color;
        private Android.Graphics.Color ColorBefore;

        protected override void OnAttached()
        {
            var effect = (XamFormEffect.Effects.FocusEffect)Element.Effects.FirstOrDefault(x => x is XamFormEffect.Effects.FocusEffect);

            if(effect != null)
            {
                Color = effect.Color.ToAndroid();
                ColorBefore = effect.ColorBefore.ToAndroid();
            }

            Control.SetBackgroundColor(ColorBefore);
        }

        protected override void OnDetached()
        {
            
        }

        protected override void OnElementPropertyChanged(PropertyChangedEventArgs args)
        {
            base.OnElementPropertyChanged(args);
            if(args.PropertyName == "IsFocused")
            {
                if(((Android.Graphics.Drawables.ColorDrawable)Control.Background).Color == Color)
                    Control.SetBackgroundColor(ColorBefore);
                else
                    Control.SetBackgroundColor(Color);
            }
        }
    }
}