﻿using System;
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
            lblData.Text = selectedDairyDate.SubjectData;
        }

        void MainNavigationClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
