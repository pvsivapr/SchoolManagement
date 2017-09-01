using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
    public partial class StudentProfile : ContentPage
    {

        bool isFromHome;
        StudentDetails selectedStdnt1;
        public StudentProfile(string imgHead, StudentDetails selectedStdnt)
        {
            selectedStdnt1 = new StudentDetails() { stdName = "SivaPrasad", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah." };

            if (imgHead == "imgHomeIcon.png")
            {
                isFromHome = true;
            }
            else
            {
                isFromHome = false;
            }
            InitializeComponent();
            //BackgroundImage = "SplashScreen.png";
            pageTitle.Text = Constants.SchoolName;
            //pageTitle.TextColor = AppGlobalVariables.orange;

            //var gridBodyHeight = (App.screenHeight * 40) / 100;
            //var gridBodyWidth = ((App.screenWidth * 1) / 100) - 40;
            //gridDataHolder.HeightRequest = gridBodyHeight;
            //gridDataHolder.WidthRequest = gridBodyWidth;
            //slider.Maximum = 100;//(App.screenWidth) - 40;//1000;//working
            ////slider.Maximum = (App.screenHeight * 40) / 100;//1000;//working
            //slider.Minimum = 0;
            //slider.Value = 0;
            //btnBorder.HeightRequest = gridBodyHeight - 68.7;
            //btnBorder.WidthRequest = gridBodyWidth - 8;
            //imgHeader.Source = ImageSource.FromFile(imgHead);
            //imgHeader.Source = ImageSource.FromFile(imgHead);

            imgProfilePic.Source = ImageSource.FromFile("UserProfile.png");
            imgProfilePic.HeightRequest = 150;
            imgProfilePic.WidthRequest = 150;
            lblNameData.Text = selectedStdnt1.stdName;//"Grandhi Veera Venkata Satya Naga Rama Praveen";
            lblRollNoData.Text = selectedStdnt1.stdRollNo;//"09A91A0152";
            lblClassData.Text = selectedStdnt1.stdClass;//"IV";
            lblMobileData.Text = selectedStdnt1.stdMobile;//"9998887775";
            lblEmailData.Text = selectedStdnt1.stdEmail;//"VenkataSivaprasadReddyPulagam@gmail.com";
            lblAddressData.Text = selectedStdnt1.stdAddress;//"B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah.";
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
