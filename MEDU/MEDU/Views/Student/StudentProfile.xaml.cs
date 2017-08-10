using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
    public partial class StudentProfile : ContentPage
    {

        bool isFromHome;
        public StudentProfile(string imgHead)
        {
            if (imgHead == "imgHomeIcon.png")
            {
                isFromHome = true;
            }
            else
            {
                isFromHome = false;
            }
            InitializeComponent();
            imgHeader.Source = ImageSource.FromFile(imgHead);
            gridHeader.BackgroundColor = AppGlobalVariables.orange;
        }
        void MainNavigationClicked(object sender, EventArgs e)
        {
            if (isFromHome == true)
            {
                Navigation.PopModalAsync();
            }
            else
            {
                var ParentPage = (MasterDetailPage)this.Parent;
                ParentPage.IsPresented = (ParentPage.IsPresented == false) ? true : false;
            }
        }
    }
}
