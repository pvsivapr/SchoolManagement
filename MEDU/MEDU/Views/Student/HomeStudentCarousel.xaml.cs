using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MEDU
{
    public partial class HomeStudentCarousel : CarouselPage
    {
        //public DotButtonsLayout dotLayout;
        //public CarouselView carousel;
        Label lblSkip;
        public HomeStudentCarousel(StudentDetails selectedStdnt)
        {
            InitializeComponent();
            Title = "";
            BackgroundImage = "BG.png";

            Children.Add(new StudentProfile("imgHomeIcon.png", selectedStdnt));
            Children.Add(new HomeStudent());
            /*
            ObservableCollection<Details> collection = new ObservableCollection<Details>
            {
                new Details{data= new HomeStudent_Page() },
                new Details{data= new HomeStudent_Profile()}
            };
            BackgroundColor = Color.FromHex("#FFFFFF");


            #region for declaring and inatialise carousel view
            var carouseHeight = (App.screenHeight * 85) / 100;
            carousel = new CarouselView()
            {
                BackgroundColor = Color.Transparent,
                HeightRequest = carouseHeight,
                //HorizontalOptions = LayoutOptions.End
                VerticalOptions = LayoutOptions.End

            };
            carousel.ItemTemplate = new DataTemplate(typeof(HomeStudentTemplate));
            carousel.PositionSelected += pageChanged;
            #endregion

            carousel.ItemsSource = collection;
            StackLayout carouselStack = new StackLayout()
            {
                Children = { carousel },
                BackgroundColor = Color.Transparent,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };

            //downstack.Children.Add(carousel);

            dotLayout = new DotButtonsLayout(collection.Count, Color.White, 11);

            foreach (DotButton dot in dotLayout.dots)
            {
                dot.Clicked += dotClicked;
            }


            StackLayout dotStack = new StackLayout()
            {
                BackgroundColor = Color.Transparent,
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.End
            };
            dotStack.Children.Add(dotLayout);

            var pageSpacing = (App.screenHeight * 4.322535211) / 100;//(screenHeight * 7.322535211) / 100;

            StackLayout stack = new StackLayout()
            {
                //Children = { stackSkip, downstack, buttonstack },
                Children = { carouselStack, dotStack },
                Spacing = pageSpacing,
                //StartColor = Color.FromHex("#9bdcfd"),
                //EndColor = Color.FromHex("#1e9bde"),
                HorizontalOptions = LayoutOptions.FillAndExpand,
                VerticalOptions = LayoutOptions.FillAndExpand
            };
            //PageControlsStackLayout.Children.Add(stack);

            Content = stack;

        }
        private void pageChanged(object sender, SelectedPositionChangedEventArgs e)
        {
            var position = (int)(e.SelectedPosition);
            for (int i = 0; i < dotLayout.dots.Length; i++)
            {
                if (position == i)
                {
                    dotLayout.dots[i].Source = ImageSource.FromFile("dotViewSelected.png");
                }
                else
                {
                    dotLayout.dots[i].Source = ImageSource.FromFile("dotViewUnselected.png");
                }
            }
        }

        private void dotClicked(object sender)
        {
            var button = (DotButton)sender;
            int index = button.index;
            carousel.Position = index;
        }
        */
        }

        /*
        public class Details
        {
            public View data { get; set; }
            public int position { get; set; }
            public string Header { get; set; }
            public string Content { get; set; }
        }

        public class DotButtonsLayout : StackLayout
        {
            public DotButton[] dots;
            public DotButtonsLayout(int dotCount, Color dotColor, int dotSize)
            {

                dots = new DotButton[dotCount];

                Orientation = StackOrientation.Horizontal;
                VerticalOptions = LayoutOptions.Center;
                HorizontalOptions = LayoutOptions.Center;
                Spacing = (App.screenHeight * 2) / 100;//(BaseContentPage.screenHeight*2.717) / 36.8;

                for (int i = 0; i < dotCount; i++)
                {
                    dots[i] = new DotButton
                    {
                        HeightRequest = dotSize,
                        WidthRequest = dotSize,
                        Source = ImageSource.FromFile("dotViewUnselected.png"),
                        //BackgroundColor = dotColor,
                        //Opacity = 0.2
                    };
                    dots[i].index = i;
                    dots[i].layout = this;
                    Children.Add(dots[i]);
                }
                dots[0].Source = ImageSource.FromFile("dotViewSelected.png");
            }
        }


        public class DotButton : Image
        {
            public int index;
            public DotButtonsLayout layout;
            public event ClickHandler Clicked;
            public delegate void ClickHandler(DotButton sender);
            public DotButton()
            {
                //Source = ImageSource.FromFile("dotViewUnselected.png");
                var clickCheck = new TapGestureRecognizer()
                {
                    Command = new Command(() =>
                        {
                            if (Clicked != null)
                            {
                                Clicked(this);
                            }
                        })
                };
                GestureRecognizers.Add(clickCheck);
            }
        }

        public class HomeStudentTemplate : View
        {
            protected override void OnBindingContextChanged()
            {
                base.OnBindingContextChanged();
                var item = BindingContext as Details;
                View = item.data;
            }
        }

        public class HomeStudent_Profile : ViewCell
        {
            public HomeStudent_Profile()
            {
                var styleLblStaticData = new Style(typeof(Label))
                {
                    Setters =
                    {
                        new Setter{ Property=Label.FontAttributesProperty, Value=FontAttributes.Bold },
                        new Setter{ Property=Label.HorizontalTextAlignmentProperty, Value=LayoutOptions.Start },
                        new Setter{ Property=Label.VerticalTextAlignmentProperty, Value=LayoutOptions.Start },
                        new Setter{ Property=Label.HorizontalOptionsProperty, Value=LayoutOptions.Start },
                        new Setter{ Property=Label.VerticalOptionsProperty, Value=LayoutOptions.StartAndExpand }
                    }
                };

                var styleLblDynamicData = new Style(typeof(Label))
                {
                    Setters =
                    {
                        new Setter{ Property=Label.HorizontalTextAlignmentProperty, Value=LayoutOptions.Start },
                        new Setter{ Property=Label.VerticalTextAlignmentProperty, Value=LayoutOptions.Start },
                        new Setter{ Property=Label.HorizontalOptionsProperty, Value=LayoutOptions.Start },
                        new Setter{ Property=Label.VerticalOptionsProperty, Value=LayoutOptions.StartAndExpand}
                    }
                };
                Resources = new ResourceDictionary();
                Resources.Add("styleLblStaticData", styleLblStaticData);
                Resources.Add("styleLblDynamicData", styleLblDynamicData);


                Image imgStdProfile = new Image()
                {
                    Source = ImageSource.FromFile(""),
                    HorizontalOptions = LayoutOptions.CenterAndExpand,
                    VerticalOptions = LayoutOptions.StartAndExpand
                };

                StackLayout stackImageHolder = new StackLayout()
                {
                    Children = { imgStdProfile }
                };

                Label lblNameStaticData = new Label()
                {
                    Text = "Name : ",
                    Style = (Style)Resources["styleLblStaticData"]
                };
                Label lblRollNoStaticData = new Label()
                {
                    Text = "Roll No. : ",
                    Style = (Style)Resources["styleLblStaticData"]
                };
                Label lblClassStaticData = new Label()
                {
                    Text = "Class : ",
                    Style = (Style)Resources["styleLblStaticData"]
                };
                Label lblMobileStaticData = new Label()
                {
                    Text = "Mobile : ",
                    Style = (Style)Resources["styleLblStaticData"]
                };
                Label lblEmailStaticData = new Label()
                {
                    Text = "Email id : ",
                    Style = (Style)Resources["styleLblStaticData"]
                };
                Label lblAddressStaticData = new Label()
                {
                    Text = "Address : ",
                    Style = (Style)Resources["styleLblStaticData"]
                };

                Label lblNameDynamicData = new Label()
                {
                    Text = "Grandhi Veera Venkata Satya Naga Rama Praveen",
                    Style = (Style)Resources["styleLblDynamicData"]
                };
                Label lblRollNoDynamicData = new Label()
                {
                    Text = "09A91A0152",
                    Style = (Style)Resources["styleLblDynamicData"]
                };
                Label lblClassDynamicData = new Label()
                {
                    Text = "IV",
                    Style = (Style)Resources["styleLblDynamicData"]
                };
                Label lblMobileDynamicData = new Label()
                {
                    Text = "9998887775",
                    Style = (Style)Resources["styleLblDynamicData"]
                };
                Label lblEmailDynamicData = new Label()
                {
                    Text = "VenkataSivaprasadReddyPulagam@gmail.com",
                    Style = (Style)Resources["styleLblDynamicData"]
                };
                Label lblAddressDynamicData = new Label()
                {
                    Text = "B-6, M.J.Manzil, Ashapura Colony, Rajampeta, Tirupahi, Cuddapah.",
                    Style = (Style)Resources["styleLblDynamicData"]
                };

                Grid gridDataHolder = new Grid()
                {
                    RowDefinitions =
                    {
                        new RowDefinition{ Height=new GridLength(1,GridUnitType.Star)},
                        new RowDefinition{ Height=new GridLength(1,GridUnitType.Star)},
                        new RowDefinition{ Height=new GridLength(1,GridUnitType.Star)},
                        new RowDefinition{ Height=new GridLength(1,GridUnitType.Star)},
                        new RowDefinition{ Height=new GridLength(1,GridUnitType.Star)},
                        new RowDefinition{ Height=new GridLength(1,GridUnitType.Star)}
                    },
                    ColumnDefinitions =
                    {
                        new ColumnDefinition{ Width=new GridLength(1,GridUnitType.Star)},
                        new ColumnDefinition{ Width=new GridLength(1,GridUnitType.Star)}
                    },
                };
                gridDataHolder.Children.Add(lblNameStaticData, 0, 0);
                gridDataHolder.Children.Add(lblNameDynamicData, 1, 0);
                gridDataHolder.Children.Add(lblRollNoStaticData, 0, 1);
                gridDataHolder.Children.Add(lblRollNoDynamicData, 1, 1);
                gridDataHolder.Children.Add(lblClassStaticData, 0, 2);
                gridDataHolder.Children.Add(lblClassDynamicData, 1, 2);
                gridDataHolder.Children.Add(lblMobileStaticData, 0, 3);
                gridDataHolder.Children.Add(lblMobileDynamicData, 1, 3);
                gridDataHolder.Children.Add(lblEmailStaticData, 0, 4);
                gridDataHolder.Children.Add(lblEmailDynamicData, 1, 4);
                gridDataHolder.Children.Add(lblAddressStaticData, 0, 5);
                gridDataHolder.Children.Add(lblAddressDynamicData, 1, 5);


                StackLayout stackDataHolder = new StackLayout()
                {
                    Children = { gridDataHolder }
                };

                ScrollView scrollDataHolder = new ScrollView()
                {
                    Content = stackDataHolder
                };

                StackLayout stackMain = new StackLayout()
                {
                    Children = { stackImageHolder, scrollDataHolder },
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand
                };
                //Content = stackMain;
                //View = stackMain;
            }
        }

        public class HomeStudent_Page : View
        {
            public HomeStudent_Page()
            {

                #region for 
                #endregion

                #region for styles
                var styleImgHome = new Style(typeof(Image))
                {
                    Setters =
                    {
                        new Setter{ Property=Image.HeightRequestProperty, Value=95 },
                        new Setter{ Property=Image.WidthRequestProperty, Value=95 },
                        new Setter{ Property=Image.HorizontalOptionsProperty, Value=LayoutOptions.CenterAndExpand },
                        new Setter{ Property=Image.VerticalOptionsProperty, Value=LayoutOptions.CenterAndExpand }
                    }
                };

                var styleLblHome = new Style(typeof(Label))
                {
                    Setters =
                    {
                        new Setter{ Property=Label.TextColorProperty, Value=Color.Black },
                        new Setter{ Property=Label.HorizontalOptionsProperty, Value=LayoutOptions.CenterAndExpand },
                        new Setter{ Property=Label.VerticalOptionsProperty, Value=LayoutOptions.CenterAndExpand}
                    }
                };

                var styleStackHome = new Style(typeof(StackLayout))
                {
                    Setters =
                    {
                        new Setter{ Property=StackLayout.HorizontalOptionsProperty, Value=LayoutOptions.FillAndExpand },
                        new Setter{ Property=StackLayout.VerticalOptionsProperty, Value=LayoutOptions.FillAndExpand }
                    }
                };
                Resources = new ResourceDictionary();
                Resources.Add("styleImgHome", styleImgHome);
                Resources.Add("styleLblHome", styleLblHome);
                Resources.Add("styleStackHome", styleStackHome);
                #endregion

                #region for Header
                Image imgHeaderNavigation = new Image()
                {
                    Source = ImageSource.FromFile("imgHamburger.png"),
                    Margin = new Thickness(10, 0, 30, 0),
                    HorizontalOptions = LayoutOptions.StartAndExpand,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
                TapGestureRecognizer gestureImgNavi = new TapGestureRecognizer();
                gestureImgNavi.NumberOfTapsRequired = 1;
                gestureImgNavi.Tapped += MainNavigationClicked;
                imgHeaderNavigation.GestureRecognizers.Add(gestureImgNavi);

                Label pageTitle = new Label()
                {
                    Text = "Oxford Public School",
                };
                Image imgHeaderSignOut = new Image()
                {
                    Source = ImageSource.FromFile("power.png"),
                    Margin = new Thickness(30, 0, 10, 0),
                    HorizontalOptions = LayoutOptions.EndAndExpand,
                    VerticalOptions = LayoutOptions.CenterAndExpand
                };
                TapGestureRecognizer gestureImgSignOut = new TapGestureRecognizer();
                gestureImgSignOut.NumberOfTapsRequired = 1;
                gestureImgSignOut.Tapped += SignOutClicked;
                imgHeaderSignOut.GestureRecognizers.Add(gestureImgSignOut);

                Grid gridHeaderHolder = new Grid()
                {
                    RowDefinitions =
                    {
                        new RowDefinition{ Height=new GridLength(1,GridUnitType.Star)}
                    },
                    ColumnDefinitions =
                    {
                        new ColumnDefinition{ Width=new GridLength(1,GridUnitType.Star)},
                        new ColumnDefinition{ Width=new GridLength(2,GridUnitType.Star)},
                        new ColumnDefinition{ Width=new GridLength(1,GridUnitType.Star)}
                    },
                    BackgroundColor = AppGlobalVariables.orange,
                    HeightRequest = (App.screenHeight * 10) / 100,
                    HorizontalOptions = LayoutOptions.FillAndExpand
                };
                gridHeaderHolder.Children.Add(imgHeaderNavigation, 0, 0);
                gridHeaderHolder.Children.Add(pageTitle, 1, 0);
                gridHeaderHolder.Children.Add(imgHeaderSignOut, 2, 0);
                #endregion


                #region for Body
                #region for 1
                Image imgStdProfile = new Image()
                {
                    Source = ImageSource.FromFile("UserProfile.png"),
                    Style = (Style)Resources["styleImgHome"]
                };
                Label lblStdProfile = new Label()
                {
                    Text = "Profile",
                    Style = (Style)Resources["styleLblHome"]
                };
                StackLayout stackStdProfileHolder = new StackLayout()
                {
                    Children = { imgStdProfile, lblStdProfile },
                    Style = (Style)Resources["styleStackHome"]
                };
                #endregion

                #region for 2
                Image imgStdDairy = new Image()
                {
                    Source = ImageSource.FromFile("Dairy.png"),
                    Style = (Style)Resources["styleImgHome"]
                };
                Label lblStdDairy = new Label()
                {
                    Text = "Dairy",
                    Style = (Style)Resources["styleLblHome"]
                };
                StackLayout stackStdDairyHolder = new StackLayout()
                {
                    Children = { imgStdDairy, lblStdDairy },
                    Style = (Style)Resources["styleStackHome"]
                };
                #endregion

                #region for 3
                Image imgStdExams = new Image()
                {
                    Source = ImageSource.FromFile("Exams.png"),
                    Style = (Style)Resources["styleImgHome"]
                };
                Label lblStdExams = new Label()
                {
                    Text = "Exams",
                    Style = (Style)Resources["styleLblHome"]
                };
                StackLayout stackStdExamsHolder = new StackLayout()
                {
                    Children = { imgStdExams, lblStdExams },
                    Style = (Style)Resources["styleStackHome"]
                };
                #endregion

                #region for 4
                Image imgStdEvents = new Image()
                {
                    Source = ImageSource.FromFile("Events.png"),
                    Style = (Style)Resources["styleImgHome"]
                };
                Label lblStdEvents = new Label()
                {
                    Text = "Events",
                    Style = (Style)Resources["styleLblHome"]
                };
                StackLayout stackStdEventsHolder = new StackLayout()
                {
                    Children = { imgStdEvents, lblStdEvents },
                    Style = (Style)Resources["styleStackHome"]
                };
                #endregion

                #region for 5
                Image imgStdHolidays = new Image()
                {
                    Source = ImageSource.FromFile("Holidays.png"),
                    Style = (Style)Resources["styleImgHome"]
                };
                Label lblStdHolidays = new Label()
                {
                    Text = "Holidays",
                    Style = (Style)Resources["styleLblHome"]
                };
                StackLayout stackStdHolidaysHolder = new StackLayout()
                {
                    Children = { imgStdHolidays, lblStdHolidays },
                    Style = (Style)Resources["styleStackHome"]
                };
                #endregion

                #region for 6
                Image imgStdFees = new Image()
                {
                    Source = ImageSource.FromFile("Fees.png"),
                    Style = (Style)Resources["styleImgHome"]
                };
                Label lblStdFees = new Label()
                {
                    Text = "Fees",
                    Style = (Style)Resources["styleLblHome"]
                };
                StackLayout stackStdFeesHolder = new StackLayout()
                {
                    Children = { imgStdFees, lblStdFees },
                    Style = (Style)Resources["styleStackHome"]
                };
                #endregion

                #region for 7
                Image imgHelpDesk = new Image()
                {
                    Source = ImageSource.FromFile("AboutUs.png"),
                    Style = (Style)Resources["styleImgHome"]
                };
                Label lblHelpDesk = new Label()
                {
                    Text = "Help Desk",
                    Style = (Style)Resources["styleLblHome"]
                };
                StackLayout stackHelpDeskHolder = new StackLayout()
                {
                    Children = { imgHelpDesk, lblHelpDesk },
                    Style = (Style)Resources["styleStackHome"]
                };
                #endregion

                Grid gridDataHolder = new Grid()
                {
                    RowDefinitions =
                    {
                        new RowDefinition{ Height=new GridLength(1,GridUnitType.Star)},
                        new RowDefinition{ Height=new GridLength(1,GridUnitType.Star)},
                        new RowDefinition{ Height=new GridLength(1,GridUnitType.Star)}
                    },
                    ColumnDefinitions =
                    {
                        new ColumnDefinition{ Width=new GridLength(1,GridUnitType.Star)},
                        new ColumnDefinition{ Width=new GridLength(1,GridUnitType.Star)},
                        new ColumnDefinition{ Width=new GridLength(1,GridUnitType.Star)}
                    },
                };
                gridDataHolder.Children.Add(stackStdProfileHolder, 0, 0);
                gridDataHolder.Children.Add(stackStdDairyHolder, 1, 0);
                gridDataHolder.Children.Add(stackStdExamsHolder, 2, 0);
                gridDataHolder.Children.Add(stackStdEventsHolder, 0, 1);
                gridDataHolder.Children.Add(stackStdHolidaysHolder, 1, 1);
                gridDataHolder.Children.Add(stackStdFeesHolder, 2, 1);
                gridDataHolder.Children.Add(stackHelpDeskHolder, 0, 2);


                StackLayout stackDataHolder = new StackLayout()
                {
                    Children = { gridDataHolder }
                };

                ScrollView scrollDataHolder = new ScrollView()
                {
                    Content = stackDataHolder
                };
                #endregion

                #region for container
                StackLayout stackMain = new StackLayout()
                {
                    Children = { gridHeaderHolder, scrollDataHolder },
                    HorizontalOptions = LayoutOptions.FillAndExpand,
                    VerticalOptions = LayoutOptions.FillAndExpand
                };
                #endregion
                //Content = stackMain;
                //View = stackMain;
            }
            void MainNavigationClicked(object sender, EventArgs e)
            {
                try
                {
                    var ParentPage = (MasterDetailPage)this.Parent;
                    ParentPage.IsPresented = (ParentPage.IsPresented == false) ? true : false;
                }
                catch (Exception ex)
                {
                    var msg = ex.Message;
                }
            }
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
            }*/
    }
}