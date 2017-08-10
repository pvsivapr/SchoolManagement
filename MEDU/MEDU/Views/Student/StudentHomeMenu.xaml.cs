using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
    public partial class StudentHomeMenu : ContentPage
    {
        public ListView lvMenu { get { return listView; } }
        public StudentHomeMenu()
        {
            InitializeComponent();
            scrollPageHolder.BackgroundColor = AppGlobalVariables.orange;
            stackPageHolder.BackgroundColor = AppGlobalVariables.orange;
            var masterPageItems = new List<MasterPageItem>();

            masterPageItems.Add(new MasterPageItem
            {
                Title = "HOME",
                IconSource = "imgHamburger.png",
                TargetType = typeof(HomeStudent)
            });

            masterPageItems.Add(new MasterPageItem
            {
                Title = "MY PROFILE",
                IconSource = "imgHamburger.png",
                TargetType = typeof(HomeStudent)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "MY DAIRY",
                IconSource = "imgHamburger.png",
                TargetType = typeof(HomeStudent)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "MY EXAMS",
                IconSource = "imgHamburger.png",
                TargetType = typeof(HomeStudent)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "MY EVENTS",
                IconSource = "imgHamburger.png",
                TargetType = typeof(HomeStudent)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "MY HOLIDAYS",
                IconSource = "imgHamburger.png",
                TargetType = typeof(HomeStudent)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "FEES",
                IconSource = "imgHamburger.png",
                TargetType = typeof(HomeStudent)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "ABOUT US",
                IconSource = "imgHamburger.png",
                TargetType = typeof(HomeStudent)
            });

            lvMenu.ItemsSource = masterPageItems;
            lvMenu.ItemSelected += SelectedPage;
        }

        void SelectedPage(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var examData = ((ListView)sender).SelectedItem as MasterPageItem;
                var parentDetailView = (MasterDetailPage)this.Parent;
                parentDetailView.IsPresented = false;
                if (examData == null)
                {
                    return;
                }
                if (examData.Title == "HOME")
                {
                    parentDetailView.Detail = new HomeStudent() { BackgroundColor = Color.White, };
                }
                else if (examData.Title == "PROFILE")
                {
                    parentDetailView.Detail = new StudentProfile() { BackgroundColor = Color.White, };
                }
                else if (examData.Title == "MY DAIRY")
                {
                    parentDetailView.Detail = new StudentDairy() { BackgroundColor = Color.White, };
                }
                else if (examData.Title == "MY EXAMS")
                {
                    parentDetailView.Detail = new StudentExams() { BackgroundColor = Color.White, };
                }
                else if (examData.Title == "MY EVENTS")
                {
                    parentDetailView.Detail = new StudentEvents() { BackgroundColor = Color.White, };
                }
                else if (examData.Title == "MY HOLIDAYS")
                {
                    parentDetailView.Detail = new StudentHolidays() { BackgroundColor = Color.White, };
                }
                else if (examData.Title == "FEES")
                {
                    parentDetailView.Detail = new StudentCourseFee() { BackgroundColor = Color.White, };
                }
                else if (examData.Title == "ABOUT US")
                {
                    parentDetailView.Detail = new Aboutus() { BackgroundColor = Color.White, };
                }
                else
                {

                }
                ((ListView)sender).SelectedItem = null;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
    }

    public class MasterPageItem
    {
        public string Title { get; set; }

        public string IconSource { get; set; }

        public Type TargetType { get; set; }
    }
}