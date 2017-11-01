    using System;

using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Support.V7.Widget;

namespace SearchBarOnNavBarForms.Droid
{
    [Activity(Label = "SearchBarOnNavBarForms.Droid", Icon = "@drawable/icon", Theme = "@style/MyTheme", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
    public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsAppCompatActivity
    {
<<<<<<< HEAD
        public Android.Support.V7.Widget.Toolbar ToolBar;

        public static Android.Support.V7.Widget.Toolbar ToolBar2;

=======
        public static Android.Support.V7.Widget.Toolbar ToolBar { get;  set; }     
>>>>>>> fc31aa25a0009c8d9b4a0f2a5c3a465c60bb1649
        protected override void OnCreate(Bundle bundle)
        {
            TabLayoutResource = Resource.Layout.Tabbar;
            ToolbarResource = Resource.Layout.Toolbar;

            ToolBar = (Android.Support.V7.Widget.Toolbar)LayoutInflater.Inflate(ToolbarResource, null);
            ToolBar2 = (Android.Support.V7.Widget.Toolbar)LayoutInflater.Inflate(ToolbarResource, null);

            // SetSupportActionBar(ToolBar);


            base.OnCreate(bundle);

            global::Xamarin.Forms.Forms.Init(this, bundle);


            /*ToolBar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Layout.Toolbar);
            ToolBar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);

            ToolBar2 = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Layout.Toolbar);
            ToolBar2 = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);*/

            LoadApplication(new App());
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            return base.OnCreateOptionsMenu(menu);
        }
    }
}
