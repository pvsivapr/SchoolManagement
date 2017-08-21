using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
    public partial class StudentHolidaysDetail : ContentPage
    {
        public StudentHolidaysDetail(Holidays selectedHolidayData)
        {
            InitializeComponent();
            pageTitle.Text = selectedHolidayData.HolidayNames;
            gridHeader.BackgroundColor = AppGlobalVariables.orange;
            lblNameData.Text = selectedHolidayData.HolidayNames;
            lblDateData.Text = selectedHolidayData.HolidayDates;
            lblResultData.Text = selectedHolidayData.HolidayRemarks;
        }

        void MainNavigationClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
