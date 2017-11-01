using System;

using Android.Widget;
using Android.Views.InputMethods;
using Android.Text;
using Android.Runtime;

using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Plugin.CurrentActivity;

using SearchBarOnNavBarForms;
using SearchBarOnNavBarForms.Renderers;
using SearchBarOnNavBarForms.Droid;

using SearchView = Android.Support.V7.Widget.SearchView;



[assembly: ExportRenderer(typeof(SearchPage), typeof(SearchPageRenderer))]
namespace SearchBarOnNavBarForms.Droid
{
    public class SearchPageRenderer : PageRenderer
    {
        private SearchView _searchView;
        private static Toolbar GetToolbar() =>(CrossCurrentActivity.Current?.Activity as MainActivity)?.FindViewById<Toolbar>(Resource.Id.toolbar);
        private MainActivity _mainActivity;

        protected override void OnElementChanged(ElementChangedEventArgs<Page> e)
        {
            base.OnElementChanged(e);

            if (e?.NewElement == null || e?.OldElement != null)
            {
                return;
            }
            _mainActivity = this.Context as MainActivity;
            AddSearchToToolBar();
        }

        protected override void Dispose(bool disposing)
        {
            if(_searchView != null)
            {
                _searchView.QueryTextChange += _searchView_QueryTextChange;
                _searchView.QueryTextSubmit += _searchView_QueryTextSubmit;
            }
            _mainActivity?.ToolBar?.Menu?.RemoveItem(Resource.Menu.mainmenu);
            MainActivity.ToolBar2?.Menu?.RemoveItem(Resource.Menu.mainmenu);
            base.Dispose(disposing);
        }

        void _searchView_QueryTextChange(object sender, SearchView.QueryTextChangeEventArgs e)
        {
            var searchPage = Element as SearchPage;
            if (searchPage == null)
            {
                return;
            }
            searchPage.SearchText = e?.NewText;
        }

        void _searchView_QueryTextSubmit(object sender, SearchView.QueryTextSubmitEventArgs e)
        {
            if (e == null)
            {
                return;
            }

            var searchPage = Element as SearchPage;
            if (searchPage == null)
            {
                return;
            }
            searchPage.SearchText = e.Query;
            searchPage.SearchCommand?.Execute(e.Query);
            e.Handled = true;
        }

        private void AddSearchToToolBar()
        {
            /*
            if(MainActivity.ToolBar2 == null || Element == null)
            {
                return;
            }
            MainActivity.ToolBar2.Title = Element.Title;
            MainActivity.ToolBar2.InflateMenu(Resource.Menu.mainmenu);

            _searchView = MainActivity.ToolBar2.Menu?.FindItem(Resource.Id.action_search)?.ActionView?.JavaCast<SearchView>();

            if(_searchView == null)
            {
                return;
            }
            _searchView.QueryTextChange += _searchView_QueryTextChange;
            _searchView.QueryTextSubmit += _searchView_QueryTextSubmit;
            _searchView.QueryHint = (Element as SearchPage)?.SearchPlaceHolderText;
            _searchView.ImeOptions = (int)ImeAction.Search;
            _searchView.InputType = (int)InputTypes.TextVariationNormal;
            _searchView.MaxWidth = int.MaxValue;
            */



            if (_mainActivity.ToolBar == null || Element == null)
            {
                return;
            }
            _mainActivity.ToolBar.Title = "element";//Element.Title;
            _mainActivity.ToolBar.InflateMenu(Resource.Menu.mainmenu);

            _searchView = _mainActivity?.ToolBar.Menu?.FindItem(Resource.Id.action_search)?.ActionView?.JavaCast<SearchView>();

            if (_searchView == null)
            {
                return;
            }
            _searchView.QueryTextChange += _searchView_QueryTextChange;
            _searchView.QueryTextSubmit += _searchView_QueryTextSubmit;
            _searchView.QueryHint = (Element as SearchPage)?.SearchPlaceHolderText;
            _searchView.ImeOptions = (int)ImeAction.Search;
            _searchView.InputType = (int)InputTypes.TextVariationNormal;
            _searchView.MaxWidth = int.MaxValue;

        }
    }
}
