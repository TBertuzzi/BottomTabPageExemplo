using System;

using Android.App;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Naxam.Controls.Platform.Droid;
using Android.Graphics;

namespace BottomTabPageExemplo.Droid
{
    [Activity(Label = "BottomTabPageExemplo", Icon = "@mipmap/icon", Theme = "@style/MainTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            base.OnCreate(bundle);

            //Customizações
			BottomTabbedRenderer.BackgroundColor = new Android.Graphics.Color(23, 31, 50);
            BottomTabbedRenderer.FontSize = 10;
            BottomTabbedRenderer.IconSize = 20;
            BottomTabbedRenderer.ItemSpacing = 8;
            BottomTabbedRenderer.ItemPadding = new Xamarin.Forms.Thickness(8);
            BottomTabbedRenderer.BottomBarHeight = 80;

            global::Xamarin.Forms.Forms.Init(this, bundle);
            LoadApplication(new App());
        }
    }
}

