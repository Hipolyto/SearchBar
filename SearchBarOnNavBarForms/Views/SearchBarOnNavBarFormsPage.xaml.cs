using Xamarin.Forms;
using SearchBarOnNavBarForms;

namespace SearchBarOnNavBarForms
{
    public partial class SearchBarOnNavBarFormsPage : ContentPage
    {
        public SearchBarOnNavBarFormsPage()
        {
            InitializeComponent();
        }

        private void SearchPageSample_Clicked(object sender, System.EventArgs e)
        {
            var page = new SearchPageSample();
            Navigation.PushAsync(page);
        }
    }
}
