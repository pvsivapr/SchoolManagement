using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Runtime.InteropServices;

namespace MEDU
{
    public partial class StudentSelection : ContentPage
    {
        int dataCount = 0;
        //ObservableCollection<StudentDetails> studentsData;
        ObservableCollection<StudentView> studentsViewData;
        public StudentSelection(ObservableCollection<StudentDetails> studentsData)
        {
            InitializeComponent();
            gridHeader.BackgroundColor = AppGlobalVariables.orange;
            int loop = 1;
            studentsViewData = new ObservableCollection<StudentView>();
            //studentsData = new ObservableCollection<StudentDetails>()
            //{
            //    new StudentDetails() { stdName = "Grandhi Veera Venkata Satya Naga Rama Praveen", stdImage="UserProfile.png", stdClass="IV", stdRollNo="09A91A0152", stdMobile="9988776655", stdEmail="VenkataSivaprasadReddyPulagam@gmail.com", stdAddress="B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
            //    new StudentDetails() { stdName = "Grandhi Veera Venkata Satya Naga Rama Reddy", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
            //    new StudentDetails() { stdName = "Grandhi Veera Venkata Satya Naga Rama Chandra", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
            //    new StudentDetails() { stdName = "SivaPrasad", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
            //    new StudentDetails() { stdName = "BalaRaju", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
            //    new StudentDetails() { stdName = "Gopi Nadh Reddy", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
            //    new StudentDetails() { stdName = "Dheeraj Chandra Teja", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
            //    new StudentDetails() { stdName = "Grandhi Veera Venkata Satya Naga Rama Reddy", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
            //    new StudentDetails() { stdName = "Grandhi Veera Venkata Satya Naga Rama Chandra", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
            //    new StudentDetails() { stdName = "SivaPrasad", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
            //    new StudentDetails() { stdName = "BalaRaju", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
            //    new StudentDetails() { stdName = "Gopi Nadh Reddy", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."},
            //    new StudentDetails() { stdName = "Dheeraj Chandra Teja", stdImage = "UserProfile.png", stdClass = "IV", stdRollNo = "09A91A0152", stdMobile = "9988776655", stdEmail = "VenkataSivaprasadReddyPulagam@gmail.com", stdAddress = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah."}
            //};
            StackLayout StackView = new StackLayout();
            foreach (var item in studentsData)
            {
                var stackItem = GetSubView(item);
                StudentView sv = new StudentView()
                {
                    stdView = stackItem
                };
                studentsViewData.Add(sv);

                if (loop <= 3)
                {
                    if (loop == 1)
                    {
                        StackView = GetView();
                        stackStdsBody.Children.Add(StackView);
                        StackView.Children.Add(stackItem);
                    }
                    else if (loop == 2)
                    {
                        StackView.Children.Add(stackItem);
                    }
                    else if (loop == 3)
                    {
                        StackView.Children.Add(stackItem);
                    }
                    else
                    {

                    }

                }
                else
                {
                    var rem = loop % 3;
                    if (rem == 1)
                    {
                        StackView = GetView();
                        stackStdsBody.Children.Add(StackView);
                        StackView.Children.Add(stackItem);
                    }
                    else if (rem == 2)
                    {
                        StackView.Children.Add(stackItem);
                    }
                    else if (rem == 0)
                    {
                        StackView.Children.Add(stackItem);
                    }
                }
                loop++;
            }
            //dataCount = studentsData.Count;
            //var rowsNeeded = GetNoOfRows(dataCount);
            //var restItems = GetRemainders(dataCount);
            //for (int i = 0; i < studentsData.Count; i++)
            //{
            //    if (i < 3)
            //    {
            //        if (i == 0)
            //        {

            //        }
            //        else if (i == 1)
            //        {

            //        }
            //        else if (i == 2)
            //        {

            //        }
            //        else
            //        {

            //        }

            //    }
            //    else
            //    {
            //        var rem = i % 3;
            //        if (rem == 1)
            //        {

            //        }
            //        else if (rem == 2)
            //        {

            //        }
            //        else if (rem == 0)
            //        {

            //        }
            //    }


            //}
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

        void SignOutClicked(object sender, EventArgs e)
        {
            try
            {
                App.Current.MainPage = new UserLogin();
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }

        void StudentClicked(object sender, EventArgs e)
        {
            App.Current.MainPage = new StudentHomeMaster();
        }

        //int GetNoOfRows(int totalNum)
        //{
        //    int rows = 0;
        //    rows = totalNum / 3;
        //    return rows;
        //}

        //int GetRemainders(int totalNum)
        //{
        //    int remains = 0;
        //    remains = totalNum % 3;
        //    return remains;
        //}

        public StackLayout GetView()
        {
            //StackLayout stackStdView = new StackLayout();
            StackLayout holder = new StackLayout()
            {
                //Children = { ImgStdPic, lblStdName },
                Orientation = StackOrientation.Horizontal,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            //if (count < 3)
            //{
            //    for (int i = 1; i < count; i++)
            //    {
            //        //stackStdView = GetSubView();
            //        holder.Children.Add(stackStdView);
            //    }

            //}
            //else
            //{
            //    for (int i = 0; i < 3; i++)
            //    {
            //        //stackStdView = GetSubView();
            //        holder.Children.Add(stackStdView);
            //    }
            //}
            return holder;
        }


        public StackLayout GetSubView(StudentDetails stdData)
        {
            ImageCircle imgStdPic = new ImageCircle()
            {
                HeightRequest = 90,
                WidthRequest = 90,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            try
            {
                imgStdPic.Source = ImageSource.FromFile(stdData.stdImage);
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
            Label lblStdName = new Label()
            {
                Text = stdData.stdName,
                TextColor = Color.Black,
                HorizontalTextAlignment = TextAlignment.Center,
                VerticalTextAlignment = TextAlignment.Start,
                HorizontalOptions = LayoutOptions.CenterAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            TapGestureRecognizer tapStdSelected = new TapGestureRecognizer();
            tapStdSelected.NumberOfTapsRequired = 1;
            tapStdSelected.Tapped += (sender, e) =>
            {
                try
                {
                    App.stdntDetails = stdData;
                    //App.Current.MainPage = new HomeStudentCarousel(stdData);
                    App.Current.MainPage = new StudentHomeMaster();
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                }
            };
            imgStdPic.GestureRecognizers.Add(tapStdSelected);
            lblStdName.GestureRecognizers.Add(tapStdSelected);
            StackLayout stackStdholder = new StackLayout()
            {
                Children = { imgStdPic, lblStdName },
                HeightRequest = (App.screenHeight * 33) / 100,
                WidthRequest = (App.screenWidth * 33) / 100
            };
            return stackStdholder;
        }
    }

    public class StudentDetails
    {
        public string stdName { get; set; }

        public string stdImage { get; set; }

        public string stdRollNo { get; set; }

        public string stdClass { get; set; }

        public string stdMobile { get; set; }

        public string stdEmail { get; set; }

        public string stdAddress { get; set; }
    }

    public class StudentView
    {
        public StackLayout stdView { get; set; }
    }
}
