using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
    public partial class HomeStudent : ContentPage
    {
        public HomeStudent()
        {
            InitializeComponent();
            gridHeader.BackgroundColor = AppGlobalVariables.orange;
        }

        void MainNavigationClicked(object sender, EventArgs e)
        {
            //Navigation.PushMc(new );
        }
        void ProfileNavigationClicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new );
        }
        void DairyNavigationClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new StudentDairy());
        }
        void ExamsNavigationClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new StudentExams());
        }
        void EventsNavigationClicked(object sender, EventArgs e)
        {
            //Navigation.PushModnew );
        }
        void HolidaysNavigationClicked(object sender, EventArgs e)
        {
            //Navigation.PushModnew );
        }
        void FeesNavigationClicked(object sender, EventArgs e)
        {
            //Navigationnew );
        }
        void AboutUsNavigationClicked(object sender, EventArgs e)
        {
            //Navigationnew );
        }

    }
}
