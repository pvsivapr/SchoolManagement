using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MEDU
{
	public partial class OTPVerification : ContentPage
	{
		//CustomProperties cp = new CustomProperties();
		public string _mobileNo;
		public OTPVerification()
		{

			InitializeComponent();
		}
		private async void BtnVerify_Click(object sender, EventArgs args)
		{


		}

		public async void GetVerificationCode()
		{


		}

		string str;

		public async void OnTapGestureRecognizerTapped(object sender, EventArgs args)
		{



		}

		public async void GetResendVerificationCode()
		{
			try
			{

			}
			catch (Exception ex)
			{

				var msg = ex.Message;
			}
		}

		public async void BackImageTapped(object sender, EventArgs args)
		{

		}

	}
}



