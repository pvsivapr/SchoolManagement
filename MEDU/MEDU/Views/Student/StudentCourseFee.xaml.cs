using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

using Xamarin.Forms;

namespace MEDU
{
    public partial class StudentCourseFee : ContentPage
    {
        ObservableCollection<CourseFee> obcFeeData;
        bool isFromHome;
        public StudentCourseFee(string imgHead)
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
            obcFeeData = new ObservableCollection<CourseFee>()
            {
                new CourseFee{FeeTitle="Term 1", FeeDates="31/07/2017", FeeStatus="Paid", FeeRemarks=" "},
                new CourseFee{FeeTitle="Term 2", FeeDates="11/12/2017", FeeStatus="Generated/Pending", FeeRemarks=" "},
                new CourseFee{FeeTitle="Term 3", FeeDates="25/02/2017", FeeStatus="Not yet Generated", FeeRemarks=" "}
            };
            lvFeeListDisplay.ItemsSource = obcFeeData;
            gridHeader.BackgroundColor = AppGlobalVariables.orange;
            lvFeeListDisplay.ItemSelected += SelectedFeeData;
        }
        void MainNavigationClicked(object sender, EventArgs e)
        {
            try
            {
                //if (((Image)sender).Source == ImageSource.FromFile("imgHomeIcon.png"))
                //{
                //    Navigation.PopModalAsync();
                //}
                //else
                //{
                //    var ParentPage = (MasterDetailPage)this.Parent;
                //    ParentPage.IsPresented = (ParentPage.IsPresented == false) ? true : false;
                //}
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
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        void SelectedFeeData(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var feeData = ((ListView)sender).SelectedItem as CourseFee;
                if (feeData == null)
                {
                    return;
                }
                Navigation.PushModalAsync(new StudentCourseFeeDetail(feeData));
                ((ListView)sender).SelectedItem = null;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
    }

    public class CourseFee
    {
        public string FeeTitle { get; set; }

        public string FeeDates { get; set; }

        public string FeeStatus { get; set; }

        public string FeeRemarks { get; set; }
    }
}
