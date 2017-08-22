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
            pageTitle.Text = Constants.SchoolName;
            pageTitle.TextColor = AppGlobalVariables.orange;
            gridDataHolder.HeightRequest = (App.screenHeight * 40) / 100;
            //imgHeader.Source = ImageSource.FromFile(imgHead);
            imgProfilePic.Source = ImageSource.FromFile("UserProfile.png");
            imgProfilePic.HeightRequest = 150;
            imgProfilePic.WidthRequest = 150;
            lblNameData.Text = "Grandhi Veera Venkata Satya Naga Rama Praveen";
            lblRollNoData.Text = "09A91A0152";
            lblClassData.Text = "IV";
            lblMobileData.Text = "9998887775";
            lblEmailData.Text = "VenkataSivaprasadReddyPulagam@gmail.com";
            lblAddressData.Text = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah.";
            //gridHeader.BackgroundColor = AppGlobalVariables.orange;
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
    }
}
