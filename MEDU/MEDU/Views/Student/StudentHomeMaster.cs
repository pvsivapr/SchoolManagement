using System;

using Xamarin.Forms;

namespace MEDU
{
    public class StudentHomeMaster : MasterDetailPage
    {
        public static StudentHomeMaster shm;
        public StudentHomeMaster()
        {
            this.Icon = null;
            this.Title = "Menu";
            shm = this;

            NavigationPage.SetHasNavigationBar(this, false);

            Application.Current.Properties["ParentPage"] = this;

            Master = new StudentHomeMenu();
            Detail = new HomeStudentCarousel(App.stdntDetails) { BackgroundColor = Color.White };
        }
    }
}

