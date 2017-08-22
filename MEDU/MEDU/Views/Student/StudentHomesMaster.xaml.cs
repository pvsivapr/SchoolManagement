using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
    public partial class StudentHomesMaster : MasterDetailPage
    {
        public StudentHomesMaster()
        {
            InitializeComponent();

            NavigationPage.SetHasNavigationBar(this, false);
            masterpage.ListView.ItemSelected += OnItemSelected;
        }

        void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var item = e.SelectedItem as MasterPageItem;
            if (item != null)
            {
                Detail = new NavigationPage((Page)Activator.CreateInstance(item.TargetType));
                masterpage.ListView.SelectedItem = null;
                IsPresented = false;
            }
        }
    }
}