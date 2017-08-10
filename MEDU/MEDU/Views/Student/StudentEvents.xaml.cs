using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace MEDU
{
    public partial class StudentEvents : ContentPage
    {
        ObservableCollection<Events> obcEventsData;
        public StudentEvents()
        {
            InitializeComponent();

            obcEventsData = new ObservableCollection<Events>()
            {
                new Events{EventNames="Independence Day", EventDates="15/08/2017", EventStatus="Scheduled", EventRemarks=" "},
                new Events{EventNames="Teacher's Day", EventDates="05/09/2017", EventStatus="Scheduled", EventRemarks=" "},
                new Events{EventNames="Ramanujan Talent Test", EventDates="01/10/2017", EventStatus="Scheduled", EventRemarks=" "},
                new Events{EventNames="Sports Day", EventDates="11/10/2017", EventStatus="Scheduled", EventRemarks=" "},
                new Events{EventNames="Childern's Day", EventDates="14/11/2017", EventStatus="Scheduled", EventRemarks=" "},
                new Events{EventNames="Parents Teachers Meeting", EventDates="--/--/----", EventStatus="Not yet scheduled", EventRemarks=" "},
                new Events{EventNames="Annual Function", EventDates="--/--/----", EventStatus="Not yet scheduled", EventRemarks=" "}
            };
            lvEventsListDisplay.ItemsSource = obcEventsData;
            gridHeader.BackgroundColor = AppGlobalVariables.orange;
            lvEventsListDisplay.ItemSelected += SelectedEventData;
        }

        void MainNavigationClicked(object sender, EventArgs e)
        {
            Navigation.PopModalAsync();
        }

        void SelectedEventData(object sender, SelectedItemChangedEventArgs e)
        {
            try
            {
                var eventData = ((ListView)sender).SelectedItem as Events;
                if (eventData == null)
                {
                    return;
                }
                Navigation.PushModalAsync(new StudentEventsDetail(eventData));
                ((ListView)sender).SelectedItem = null;
            }
            catch (Exception ex)
            {
                var msg = ex.Message;
            }
        }
    }
    public class Events
    {
        public string EventNames { get; set; }

        public string EventDates { get; set; }

        public string EventStatus { get; set; }

        public string EventRemarks { get; set; }
    }
}
