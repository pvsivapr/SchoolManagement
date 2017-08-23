using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
    public partial class StudentProfile : ContentPage
    {

        bool isFromHome;
        public StudentProfile(string imgHead, StudentDetails selectedStdnt)
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
            lblNameData.Text = selectedStdnt.stdName;//"Grandhi Veera Venkata Satya Naga Rama Praveen";
            lblRollNoData.Text = selectedStdnt.stdRollNo;//"09A91A0152";
            lblClassData.Text = selectedStdnt.stdClass;//"IV";
            lblMobileData.Text = selectedStdnt.stdMobile;//"9998887775";
            lblEmailData.Text = selectedStdnt.stdEmail;//"VenkataSivaprasadReddyPulagam@gmail.com";
            lblAddressData.Text = selectedStdnt.stdAddress;//"B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah.";
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
