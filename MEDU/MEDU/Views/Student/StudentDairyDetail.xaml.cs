using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
    public partial class StudentDairyDetail : ContentPage
    {
        public StudentDairyDetail(Dairy selectedDairyDate)
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
