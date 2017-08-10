using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
    public partial class Aboutus : ContentPage
    {
        public Aboutus()
        {
            InitializeComponent();
            gridHeader.BackgroundColor = AppGlobalVariables.orange;
        }

        void MainNavigationClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
