﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Text.RegularExpressions;
using System.Collections.ObjectModel;

namespace MEDU
{
    public partial class UserLogin : ContentPage
    {
        string selectedType;
        //Dictionary<string, string> pickerSource;
        public double HeightsRequest;
        public static ObservableCollection<StudentDetails> studentsData;

        public UserLogin()
        {
            HeightsRequest = (App.screenHeight * 8) / 100;
            InitializeComponent();
            lblOwnerName.Text = Constants.AppOwner;
            if (Device.OS == TargetPlatform.iOS)
            {
                gridBody.HeightRequest = (App.screenHeight * 21) / 100;
            }
            else
            {
                gridBody.HeightRequest = (App.screenHeight * 28) / 100;
            }
            btnLogin.WidthRequest = (App.screenWidth * 30) / 100;
            selectedType = "";
            entryUName.Focused += unameFocused;
            entryUName.Unfocused += unameUnFocused;
            entryUPassword.Focused += uPasswordFocused;
            entryUPassword.Unfocused += uPasswordUnFocused;
            entryUPassword.IsCustomPassword = true;
            entryUPassword.IsPassword = true;
        }

        void mobileNoChanged(object sender, TextChangedEventArgs e)
        {
            var mobileObject = (Entry)sender;
            var textValue = mobileObject.Text;
            if (textValue.Length > 10)
            {
                entryUName.Text = textValue.Remove(textValue.Length - 1);
            }
        }

        void passwordChanged(object sender, TextChangedEventArgs e)
        {
            var passwordObject = (Entry)sender;
            var textValue = passwordObject.Text;
            if (textValue.Length > 4)
            {
                entryUPassword.Text = textValue.Remove(textValue.Length - 1);
            }
        }

        void unameFocused(object sender, FocusEventArgs e)
        {
            try
            {
                lblUName.Opacity = 1;
                entryUName.Placeholder = "";
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
                if (string.IsNullOrEmpty(entryUName.Text))
                {
                    lblUName.Opacity = 0;
                    entryUName.Placeholder = "User Name";
                }
                else
                {
                    lblUName.Opacity = 1;
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        void uPasswordFocused(object sender, FocusEventArgs e)
        {
            try
            {
                lblUpasswprd.Opacity = 1;
                entryUPassword.Placeholder = "";
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        void uPasswordUnFocused(object sender, FocusEventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(entryUPassword.Text))
                {
                    lblUpasswprd.Opacity = 0;
                    entryUPassword.Placeholder = "Password";
                }
                else
                {
                    lblUpasswprd.Opacity = 1;
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        /*
        void TypeFocused(object sender, FocusEventArgs e)
        {
            try
            {
                lblUType.Opacity = 1;
                pickerUType.Title = "";
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        void TypeUnFocused(object sender, FocusEventArgs e)
        {
            try
            {
                if (((Picker)sender).SelectedIndex < 0)
                {
                    lblUType.Opacity = 0;
                    pickerUType.Title = "User Type";
                }
                else
                {
                    lblUType.Opacity = 1;
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        void SelectedPickerData(object sender, EventArgs e)
        {
            try
            {
                var owner = sender as CustomPicker;
                if (owner.SelectedIndex != -1)
                {
                    lblUType.Opacity = 1;
                    selectedType = owner.SelectedItem.ToString();
                    //DisplayAlert("Alert", selectedType, "Ok");
                }
                else
                {
                    lblUType.Opacity = 0;
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
        */

        void LoginClicked(object sender, EventArgs e)
        {
            try
            {
                /*
                if (string.IsNullOrEmpty(entryUName.Text))
                {
                    DisplayAlert("Alert", "User Name should not be empty", "Ok");
                }
                else if (!Regex.IsMatch(entryUName.Text, @"^([1-9])([0-9]*)$"))
                {
                    DisplayAlert("Alert", "User Name should Mobile Number", "Ok");
                }
                else if (entryUName.Text.Length < 10)
                {
                    DisplayAlert("Alert", "Mobile number must be 10 digits", "Ok");
                }
                else if (string.IsNullOrEmpty(entryUPassword.Text))
                {
                    DisplayAlert("Alert", "User Password should not be empty", "Ok");
                }
                else if (entryUPassword.Text.Length < 4)
                {
                    DisplayAlert("Alert", "Password must be 4 digits", "Ok");
                }
                else
                {
                    studentsData = new ObservableCollection<StudentDetails>()
                    {
                        new StudentDetails() { stdName = "Siva Prasad", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                        new StudentDetails() { stdName = "Balaraju", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                        //new StudentDetails() { stdName = "Grandhi Veera Venkata Satya Naga Rama Praveen", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                        //new StudentDetails() { stdName = "Grandhi Veera Venkata Satya Naga Rama Reddy", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                        //new StudentDetails() { stdName = "Grandhi Veera Venkata Satya Naga Rama Chandra", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                        //new StudentDetails() { stdName = "SivaPrasad", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                        //new StudentDetails() { stdName = "BalaRaju", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                        //new StudentDetails() { stdName = "Gopi Nadh Reddy", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                        //new StudentDetails() { stdName = "Dheeraj Chandra Teja", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                        //new StudentDetails() { stdName = "Grandhi Veera Venkata Satya Naga Rama Reddy", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                        //new StudentDetails() { stdName = "Grandhi Veera Venkata Satya Naga Rama Chandra", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                        //new StudentDetails() { stdName = "SivaPrasad", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                        //new StudentDetails() { stdName = "BalaRaju", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                        //new StudentDetails() { stdName = "Gopi Nadh Reddy", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                        //new StudentDetails() { stdName = "Dheeraj Chandra Teja", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."}
                    };
                    Navigation.PushModalAsync(new OTPVerification());
                    //if (studentsData.Count > 1)
                    //{
                    //    Navigation.PushModalAsync(new StudentSelection(studentsData));
                    //}
                    //else
                    //{
                    //    App.stdntDetails = studentsData[0];
                    //    App.Current.MainPage = new StudentHomeMaster();
                    //}
                    Constants.userPassCode = entryUPassword.Text;
                }
                */
                Navigation.PushModalAsync(new OTPVerification());
                /*
                studentsData = new ObservableCollection<StudentDetails>()
                {
                    new StudentDetails() { stdName = "Siva Prasad", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                    new StudentDetails() { stdName = "Balaraju", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
                };
                if (studentsData.Count > 1)
                {
                    Navigation.PushModalAsync(new StudentSelection(studentsData));
                }
                else
                {
                    App.stdntDetails = studentsData[0];
                    App.Current.MainPage = new StudentHomeMaster();
                }
                Constants.userPassCode = entryUPassword.Text;
                */
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        void MainNavigationClicked(object sender, EventArgs e)
        {
            //try
            //{
            //    //if (((Image)sender).Source == ImageSource.FromFile("imgHomeIcon.png"))
            //    //{
            //    //    Navigation.PopModalAsync();
            //    //}
            //    //else
            //    //{
            //    //    var ParentPage = (MasterDetailPage)this.Parent;
            //    //    ParentPage.IsPresented = (ParentPage.IsPresented == false) ? true : false;
            //    //}
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
            //catch (Exception ex)
            //{
            //    var msg = ex.Message;
            //}
        }

        //protected override bool OnBackButtonPressed()
        //{
        //    return base.OnBackButtonPressed();
        //}
    }
}
