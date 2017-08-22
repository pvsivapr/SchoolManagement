using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
    public partial class StudentSelection : ContentPage
    {
        public StudentSelection()
        {
            InitializeComponent();
        }

        //void MainNavigationClicked(object sender, EventArgs e)
        //{
        //    if (isFromHome == true)
        //    {
        //        Navigation.PopModalAsync();
        //    }
        //    else
        //    {
        //        var ParentPage = (MasterDetailPage)this.Parent;
        //        ParentPage.IsPresented = (ParentPage.IsPresented == false) ? true : false;
        //    }
        //}

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

        void StudentClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new StudentHomeMaster();
        }
    }
}
