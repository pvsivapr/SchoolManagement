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
            imgProfilePic.Source = ImageSource.FromFile("UserProfile.png");
            lblNameData.Text = "Name : \n\t Grandhi Veera Venkata Satya Naga Rama Praveen";
            lblRollNoData.Text = "Roll No. : \n\t 09A91A0152";
            lblClassData.Text = "Class : \n\t IV";
            lblMobileData.Text = "Mobile : \n\t 9998887775";
            lblEmailData.Text = "Email id : \n\t VenkataSivaprasadReddyPulagam@gmail.com";
            lblAddressData.Text = "Address : \n\t B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah.";
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
