using System;

using Xamarin.Forms;

namespace MEDU
{
    public class StudentHomeMaster : MasterDetailPage
    {
        public StudentHomeMaster()
        {
            this.Icon = null;
            this.Title = "Menu";

            NavigationPage.SetHasNavigationBar(this, false);

            Application.Current.Properties["ParentPage"] = this;

            Master = new StudentHomeMenu();
            Detail = new HomeStudent() { BackgroundColor = Color.White };
        }
    }
}

