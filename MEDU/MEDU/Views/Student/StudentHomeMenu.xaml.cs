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
            //imgMenuProfile.BackgroundColor = AppGlobalVariables.orange;
            //scrollPageHolder.BackgroundColor = AppGlobalVariables.orange;
            //stackPageHolder.BackgroundColor = AppGlobalVariables.orange;
            var masterPageItems = new List<MasterPageItem>();

            masterPageItems.Add(new MasterPageItem
            {
                Title = "HOME",
                IconSource = "Home.png",
                TargetType = typeof(HomeStudent)
            });

            //masterPageItems.Add(new MasterPageItem
            //{
            //    Title = "PROFILE",
            //    IconSource = "MyProfile.png",
            //    TargetType = typeof(HomeStudent)
            //});
            masterPageItems.Add(new MasterPageItem
            {
                Title = "MY DAIRY",
                IconSource = "Home.png",
                TargetType = typeof(HomeStudent)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "MY EXAMS",
                IconSource = "MyProfile.png",
                TargetType = typeof(HomeStudent)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "MY EVENTS",
                IconSource = "Home.png",
                TargetType = typeof(HomeStudent)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "MY HOLIDAYS",
                IconSource = "MyProfile.png",
                TargetType = typeof(HomeStudent)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "FEES",
                IconSource = "Home.png",
                TargetType = typeof(HomeStudent)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "SWITCH ACCOUNTS",
                IconSource = "Home.png",
                TargetType = typeof(StudentSelection)
            });
            masterPageItems.Add(new MasterPageItem
            {
                Title = "ABOUT US",
                IconSource = "MyProfile.png",
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
                    parentDetailView.Detail = new HomeStudentCarousel(App.stdntDetails) { BackgroundColor = Color.White, };
                }
                //else if (examData.Title == "PROFILE")
                //{
                //    parentDetailView.Detail = new StudentProfile("imgHamburger.png") { BackgroundColor = Color.White, };
                //}
                else if (examData.Title == "MY DAIRY")
                {
                    parentDetailView.Detail = new StudentDairy("imgHomeIcon.png") { BackgroundColor = Color.White, };
                }
                else if (examData.Title == "MY EXAMS")
                {
                    parentDetailView.Detail = new StudentExams("imgHomeIcon.png") { BackgroundColor = Color.White, };
                }
                else if (examData.Title == "MY EVENTS")
                {
                    parentDetailView.Detail = new StudentEvents("imgHomeIcon.png") { BackgroundColor = Color.White, };
                }
                else if (examData.Title == "MY HOLIDAYS")
                {
                    parentDetailView.Detail = new StudentHolidays("imgHomeIcon.png") { BackgroundColor = Color.White, };
                }
                else if (examData.Title == "FEES")
                {
                    parentDetailView.Detail = new StudentCourseFee("imgHomeIcon.png") { BackgroundColor = Color.White, };
                }
                else if (examData.Title == "SWITCH ACCOUNTS")
                {
                    parentDetailView.Detail = new StudentSelection(UserLogin.studentsData) { BackgroundColor = Color.White, };
                }
                else if (examData.Title == "ABOUT US")
                {
                    parentDetailView.Detail = new Aboutus("imgHomeIcon.png") { BackgroundColor = Color.White, };
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