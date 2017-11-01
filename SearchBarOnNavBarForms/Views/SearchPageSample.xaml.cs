using System;
using System.Collections.Generic;

using Xamarin.Forms;

using SearchBarOnNavBarForms;
using SearchBarOnNavBarForms.Renderers;

namespace SearchBarOnNavBarForms
{
    public partial class SearchPageSample : SearchPage
    {
        public SearchPageSample()
        {
            BindingContext = new SearchPageSampleViewModel();

            InitializeComponent();
        }
    }
}
