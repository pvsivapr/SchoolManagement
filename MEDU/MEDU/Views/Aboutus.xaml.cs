using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MEDU
{
	public partial class Aboutus : ContentPage
	{

		bool isFromHome;
		public Aboutus(string imgHead)
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

			//entrySubject.Focused += unameFocused;
			//entrySubject.Unfocused += unameUnFocused;

			imgHeader.Source = ImageSource.FromFile(imgHead);
			gridHeader.BackgroundColor = AppGlobalVariables.orange;
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

		private void btnSubmit_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(ediotrSubject.Text))
			{

				DisplayAlert("Alert", "Subject should not be empty", "Ok");
			}
			else if (string.IsNullOrEmpty(ediotrIssue.Text))
			{

				DisplayAlert("Alert", "Please specify the problem", "Ok");
			}
			else
			{
				App.Current.MainPage = new StudentHomeMaster();
			}
		}
	}
}
