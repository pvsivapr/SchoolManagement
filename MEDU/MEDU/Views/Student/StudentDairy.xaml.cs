using System;
using System.Collections.Generic;

using Xamarin.Forms;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace MEDU
{
    public partial class StudentDairy : ContentPage
    {
        ObservableCollection<Dairy> obcDairyData;

        bool isLoading;
        Page page;
        bool isFromHome;
        public StudentDairy(string imgHead)
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

            lvDairyListDisplay.ItemAppearing += (sender, e) =>
                        {
                            if (isLoading || obcDairyData.Count == 0)
                                return;

                            //hit bottom!
                            if (e.Item == obcDairyData[obcDairyData.Count - 1])
                            {
                                LoadItems();
                            }
                        };
            imgHeader.Source = ImageSource.FromFile(imgHead);
            obcDairyData = new ObservableCollection<Dairy>()
            {
                new Dairy{Dates="01/01/2017", Status="Completed", SubjectData="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "},
                new Dairy{Dates="02/01/2017", Status="Completed", SubjectData="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "},
                new Dairy{Dates="03/01/2017", Status="InComplete", SubjectData="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "},
                new Dairy{Dates="04/01/2017", Status="Completed", SubjectData="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "},
                new Dairy{Dates="05/01/2017", Status="Completed", SubjectData="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "},
                new Dairy{Dates="06/01/2017", Status="Completed", SubjectData="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "},
                new Dairy{Dates="08/01/2017", Status="Completed", SubjectData="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "},
                new Dairy{Dates="09/01/2017", Status="Completed", SubjectData="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "},
                new Dairy{Dates="10/01/2017", Status="Incomplete", SubjectData="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "},
                new Dairy{Dates="11/01/2017", Status="Completed", SubjectData="First Language:\n\t\t \nSecond Language:\n\t\t \nThird Language:\n\t\t \nMathematics:\n\t\t \nGeneral Sciences:\n\t\t \nSocial Studies:\n\t\t "}
            };
            lvDairyListDisplay.ItemsSource = obcDairyData;
            gridHeader.BackgroundColor = AppGlobalVariables.orange;
            lvDairyListDisplay.ItemSelected += SelectedDairyDate;
        }

        private async Task LoadItems()
        {
            isLoading = true;
            pageTitle.Text = "Loading";

            //simulator delayed load
            Device.StartTimer(TimeSpan.FromSeconds(2), () =>
            {
                pageTitle.Text = "School Dairy"; ;
                isLoading = false;
                //stop timer
                return false;
            });
        }

        void MainNavigationClicked(object sender, EventArgs e)
        {
            if (isFromHome == true)
            {
                //Navigation.PopModalAsync();
                var ParentPage = StudentHomeMaster.shm;//(MasterDetailPage)this.Parent;
                ParentPage.IsPresented = (ParentPage.IsPresented == false) ? true : false;
            }
            else
            {
                var ParentPage = (MasterDetailPage)this.Parent;
                ParentPage.IsPresented = (ParentPage.IsPresented == false) ? true : false;
            }
        }

        void SelectedDairyDate(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var dairyDate = ((ListView)sender).SelectedItem as Dairy;
                if (dairyDate == null)
                {
                    return;
                }
                Navigation.PushModalAsync(new StudentDairyDetail(dairyDate));
                ((ListView)sender).SelectedItem = null;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
    }

    public class Dairy
    {
        public string Dates { get; set; }

        public string Status { get; set; }

        public string SubjectData { get; set; }

        public static explicit operator Dairy(string v)
        {
            throw new NotImplementedException();
        }
    }
}
