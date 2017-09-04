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
                var ParentPage = StudentHomeMaster.shm;//(MasterDetailPage)this.Parent;
                ParentPage.IsPresented = (ParentPage.IsPresented == false) ? true : false;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
        void SignOutClicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new UserLogin();
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
        //void ProfileNavigationClicked(object sender, EventArgs e)
        //{
        //    Navigation.PushModalAsync(new StudentProfile("imgHomeIcon.png"));
        //}
        void DairyNavigationClicked(object sender, EventArgs e)
        {

            //Navigation.PushModalAsync(new StudentDairy("imgHomeIcon.png"));
            var ParentPage = StudentHomeMaster.shm;//(MasterDetailPage)this.Parent;
            ParentPage.Detail = new StudentDairy("imgHomeIcon.png") { BackgroundColor = Color.White, };
        }
        void ExamsNavigationClicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new StudentExams("imgHomeIcon.png"));
            var ParentPage = StudentHomeMaster.shm;//(MasterDetailPage)this.Parent;
            ParentPage.Detail = new StudentExams("imgHomeIcon.png") { BackgroundColor = Color.White, };
        }
        void EventsNavigationClicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new StudentEvents("imgHomeIcon.png"));
            var ParentPage = StudentHomeMaster.shm;//(MasterDetailPage)this.Parent;
            ParentPage.Detail = new StudentEvents("imgHomeIcon.png") { BackgroundColor = Color.White, };
        }
        void HolidaysNavigationClicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new StudentHolidays("imgHomeIcon.png"));
            var ParentPage = StudentHomeMaster.shm;//(MasterDetailPage)this.Parent;
            ParentPage.Detail = new StudentHolidays("imgHomeIcon.png") { BackgroundColor = Color.White, };
        }
        void FeesNavigationClicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new StudentCourseFee("imgHomeIcon.png"));
            var ParentPage = StudentHomeMaster.shm;//(MasterDetailPage)this.Parent;
            ParentPage.Detail = new StudentCourseFee("imgHomeIcon.png") { BackgroundColor = Color.White, };
        }
        void SwitchUserClicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new StudentSelection(UserLogin.studentsData));
            var ParentPage = StudentHomeMaster.shm;//(MasterDetailPage)this.Parent;
            ParentPage.Detail = new StudentSelection(UserLogin.studentsData) { BackgroundColor = Color.White, };
        }
        void AboutUsNavigationClicked(object sender, EventArgs e)
        {
            //Navigation.PushModalAsync(new Aboutus("imgHomeIcon.png"));
            var ParentPage = StudentHomeMaster.shm;//(MasterDetailPage)this.Parent;
            ParentPage.Detail = new Aboutus("imgHomeIcon.png") { BackgroundColor = Color.White, };
        }

    }
}
