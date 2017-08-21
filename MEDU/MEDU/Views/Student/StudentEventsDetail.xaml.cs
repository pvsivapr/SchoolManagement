using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
    public partial class StudentEventsDetail : ContentPage
    {
        public StudentEventsDetail(Events selectedEventData)
        {
            InitializeComponent();

            pageTitle.Text = selectedEventData.EventNames;
            gridHeader.BackgroundColor = AppGlobalVariables.orange;
            lblNameData.Text = selectedEventData.EventNames;
            lblDateData.Text = selectedEventData.EventDates;
            lblResultData.Text = selectedEventData.EventRemarks;
        }

        void MainNavigationClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }
    }
}
