using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MEDU
{
    public partial class StudentHolidays : ContentPage
    {
        ObservableCollection<Holidays> obcHolidaysData;
        bool isFromHome;
        public StudentHolidays(string imgHead)
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
            obcHolidaysData = new ObservableCollection<Holidays>()
            {
                new Holidays{HolidayNames="Sankranthi", HolidayDates="01/01/2017", HolidayStatus="Completed", HolidayRemarks=""},
                new Holidays{HolidayNames="Ugadhi", HolidayDates="11/04/2017", HolidayStatus="Sheduled", HolidayRemarks=""},
                new Holidays{HolidayNames="Holi", HolidayDates="14/06/2017", HolidayStatus="Sheduled", HolidayRemarks=""},
                new Holidays{HolidayNames="Ramzan", HolidayDates="11/07/2017", HolidayStatus="Sheduled", HolidayRemarks=""},
                new Holidays{HolidayNames="Sri Rama Navami", HolidayDates="20/07/2017", HolidayStatus="Sheduled", HolidayRemarks=""},
                new Holidays{HolidayNames="Dusserah", HolidayDates="04/10/2017", HolidayStatus="Sheduled", HolidayRemarks=""},
                new Holidays{HolidayNames="Deewali", HolidayDates="19/10/2017", HolidayStatus="Pending", HolidayRemarks=""},
                new Holidays{HolidayNames="Christ-Mas", HolidayDates="25/12/2017", HolidayStatus="Sheduled", HolidayRemarks=""}
            };
            lvHolidaysListDisplay.ItemsSource = obcHolidaysData;
            gridHeader.BackgroundColor = AppGlobalVariables.orange;
            lvHolidaysListDisplay.ItemSelected += SelectedHolidayData;
        }

        void MainNavigationClicked(object sender, EventArgs e)
        {
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

        void SelectedHolidayData(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var holidayData = ((ListView)sender).SelectedItem as Holidays;
                if (holidayData == null)
                {
                    return;
                }
                Navigation.PushModalAsync(new StudentHolidaysDetail(holidayData));
                ((ListView)sender).SelectedItem = null;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
    }
    public class Holidays
    {
        public string HolidayNames { get; set; }

        public string HolidayDates { get; set; }

        public string HolidayStatus { get; set; }

        public string HolidayRemarks { get; set; }
    }
}