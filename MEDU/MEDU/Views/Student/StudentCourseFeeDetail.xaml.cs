using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
    public partial class StudentCourseFeeDetail : ContentPage
    {
        public StudentCourseFeeDetail(CourseFee selectedFeeData)
        {
            InitializeComponent();
            pageTitle.Text = selectedFeeData.FeeTitle;
            gridHeader.BackgroundColor = AppGlobalVariables.orange;
            lblNameData.Text = selectedFeeData.FeeTitle;
            lblDateData.Text = selectedFeeData.FeeDates;
            lblResultData.Text = selectedFeeData.FeeRemarks;
        }

        void MainNavigationClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
