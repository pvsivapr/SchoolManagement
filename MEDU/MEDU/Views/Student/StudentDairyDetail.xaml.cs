using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
    public partial class StudentDairyDetail : ContentPage
    {
        public StudentDairyDetail(Dairy selectedDairyDate)
        {
            InitializeComponent();
            gridHeader.BackgroundColor = AppGlobalVariables.orange;
            lblData.Text = selectedDairyDate.SubjectData;
            entryUPassword.Focused += uPasswordFocused;
            entryUPassword.Unfocused += uPasswordUnFocused;
            entryUPassword.IsCustomPassword = true;
            entryUPassword.IsPassword = true;
            stackFooter.HeightRequest = (App.screenHeight * 23) / 100;
        }

        void MainNavigationClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
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

        void SubmitClicked(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(entryUPassword.Text))
                {
                    DisplayAlert("Alert", "User Password should not be empty", "Ok");
                }
                else if (entryUPassword.Text.Length < 4)
                {
                    DisplayAlert("Alert", "Password must be 4 digits", "Ok");
                }
                else if (entryUPassword.Text != Constants.userPassCode)
                {
                    DisplayAlert("Alert", "Password didn't match / wrong password entered", "Ok");
                }
                else
                {
                    DisplayAlert("Alert", "Parent Review Submitted", "Ok");
                    Navigation.PopModalAsync();
                }
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
    }
}
