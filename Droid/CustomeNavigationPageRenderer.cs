using System;
using Android.Support.V7.Graphics.Drawable;
using Android.Widget;
using Samples.Droid;
using SearchBarOnNavBarForms.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android.AppCompat;


[assembly: ExportRenderer(typeof(NavigationPage), typeof(CustomeNavigationPageRenderer))]
namespace Samples.Droid
{
    public class CustomeNavigationPageRenderer : NavigationPageRenderer
    {
        protected override void OnLayout(bool changed, int l, int t, int r, int b)
    {
        base.OnLayout(changed, l, t, r, b);
        var toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
        
        MainActivity.ToolBar = toolbar;
        
        return;
        
        for (var i = 0; i < toolbar.ChildCount; i++)
        {
            var imageButton = toolbar.GetChildAt(i) as ImageButton;

            var drawerArrow = imageButton?.Drawable as DrawerArrowDrawable;
            if (drawerArrow == null)
                continue;

            imageButton.SetImageDrawable(Forms.Context.GetDrawable(Resource.Drawable.abc_btn_check_material));
        }
    }
    }
}