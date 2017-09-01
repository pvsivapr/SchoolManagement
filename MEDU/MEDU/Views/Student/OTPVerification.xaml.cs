using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MEDU
{
    public partial class OTPVerification : ContentPage
    {
        //CustomProperties cp = new CustomProperties();
        public string _mobileNo;

        public static ObservableCollection<StudentDetails> studentsData;
        public OTPVerification()
        {
            InitializeComponent();
            if (Device.OS == TargetPlatform.iOS)
            {
                gridBody.HeightRequest = (App.screenHeight * 21) / 100;
            }
            else
            {
                gridBody.HeightRequest = (App.screenHeight * 28) / 100;
            }
            btnVerify.WidthRequest = (App.screenWidth * 30) / 100;
        }

        public void BackImageTapped(object sender, EventArgs args)
        {
            Navigation.PopModalAsync();
        }

        private void VerifyClicked(object sender, EventArgs args)
        {
            studentsData = new ObservableCollection<StudentDetails>()
            {
                new StudentDetails() { stdName = "Siva Prasad", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                new StudentDetails() { stdName = "Balaraju", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
            };
            Navigation.PushModalAsync(new OTPVerification());
            if (studentsData.Count > 1)
            {
                Navigation.PushModalAsync(new StudentSelection(studentsData));
            }
            else
            {
                App.stdntDetails = studentsData[0];
                App.Current.MainPage = new StudentHomeMaster();
            }
        }
        void unameFocused(object sender, FocusEventArgs e)
        {
            try
            {
                lblOTP.Opacity = 1;
                entryOTP.Placeholder = "";
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        void unameUnFocused(object sender, FocusEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(entryOTP.Text))
                {
                    lblOTP.Opacity = 0;
                    entryOTP.Placeholder = "User Name";
                }
                else
                {
                    lblOTP.Opacity = 1;
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        void OTPChanged(object sender, TextChangedEventArgs e)
        {
            var mobileObject = (Entry)sender;
            var textValue = mobileObject.Text;
            if (textValue.Length > 10)
            {
                entryOTP.Text = textValue.Remove(textValue.Length - 4);
            }
        }


        public async void GetVerificationCode()
        {


        }

        string str;

        public async void ReSendVerificationTapped(object sender, EventArgs args)
        {



        }

        public async void GetResendVerificationCode()
        {
            try
            {

            }
            catch (Exception ex)
            {

                var msg = ex.Message;
            }
        }

    }
}



