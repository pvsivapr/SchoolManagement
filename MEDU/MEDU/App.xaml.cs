using System;
using Xamarin.Forms;

namespace MEDU
{
    public partial class App : Application
    {
        public static int screenHeight, screenWidth;
        public static StudentDetails stdntDetails;
        public App()
        {
            InitializeComponent();
            try
            {
                //MainPage = new StudentDairyDetail(null);
                MainPage = new UserLogin();
                //MainPage = new StudentProfile("imgHomeIcon.png", null);
                //MainPage = new StudentSelection();
                //MainPage = new StudentHomeMaster();
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
