using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
    public partial class HomeStudent : ContentPage
    {
        protected override void OnAppearing()
        {
            base.OnAppearing();
            NavigationPage.SetHasNavigationBar(this, false);
        }

        public HomeStudent()
        {
            InitializeComponent();
            Title = "";
            //Icon = null;
            gridHeader.BackgroundColor = AppGlobalVariables.orange;
        }

        void MainNavigationClicked(object sender, EventArgs e)
        {
            try
            {
                var ParentPage = (MasterDetailPage)this.Parent;
                ParentPage.IsPresented = (ParentPage.IsPresented == false) ? true : false;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
        void ProfileNavigationClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new StudentProfile());
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
            Navigation.PushModalAsync(new StudentEvents());
        }
        void HolidaysNavigationClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new StudentHolidays());
        }
        void FeesNavigationClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new StudentCourseFee());
        }
        void AboutUsNavigationClicked(object sender, EventArgs e)
        {
            Navigation.PushModalAsync(new Aboutus());
        }

    }
}
