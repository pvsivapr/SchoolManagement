using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
    public partial class UserLogin : ContentPage
    {
        string selectedType;
        //Dictionary<string, string> pickerSource;
        public double HeightsRequest;
        public UserLogin()
        {
            HeightsRequest = (App.screenHeight * 8) / 100;
            InitializeComponent();
            if (Device.OS == TargetPlatform.iOS)
            {
                gridBody.HeightRequest = (App.screenHeight * 21) / 100;
            }
            else
            {
                gridBody.HeightRequest = (App.screenHeight * 28) / 100;
            }
            selectedType = "";
            entryUName.Focused += unameFocused;
            entryUName.Unfocused += unameUnFocused;
            //stackUName.HeightRequest = (App.screenHeight * 8) / 100;
            entryUPassword.Focused += uPasswordFocused;
            entryUPassword.Unfocused += uPasswordUnFocused;
            entryUPassword.IsCustomPassword = true;
            entryUPassword.IsPassword = true;
            //stackUPassword.HeightRequest = (App.screenHeight * 8) / 100;
            //pickerUType.Focused += TypeFocused;
            //pickerUType.Unfocused += TypeUnFocused;
            //pickerUType.SelectedIndexChanged += SelectedPickerData;
            ////stackUType.HeightRequest = (App.screenHeight * 8) / 100;
            //pickerSource = new Dictionary<string, string>();
            //pickerSource.Add("Student", "Student");
            //pickerSource.Add("Staff", "Staff");
            //pickerSource.Add("Admin", "Admin");
            //foreach (var item in pickerSource)
            //{
            //    pickerUType.Items.Add(item.Value);
            //}
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
                if (string.IsNullOrEmpty(entryUName.Text))
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
                if (string.IsNullOrEmpty(entryUName.Text))
                {
                    DisplayAlert("Alert", "User Name should not be empty", "Ok");
                }
                else if (string.IsNullOrEmpty(entryUPassword.Text))
                {
                    DisplayAlert("Alert", "User Password should not be empty", "Ok");
                }
                //else if (string.IsNullOrEmpty(selectedType))
                //{
                //    DisplayAlert("Alert", "User Type should not be empty", "Ok");
                //}
                else
                {
                    App.Current.MainPage = new StudentHomeMaster();
                }
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
    }
}
