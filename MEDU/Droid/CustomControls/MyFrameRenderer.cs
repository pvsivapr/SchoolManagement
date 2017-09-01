using System;
using Android.Graphics.Drawables;
using Android.Text;
using Android.Util;
using MEDU;
using MEDU.Droid;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

//using System.ComponentModel;
//using System.Diagnostics;
//using System.Drawing;

[assembly: ExportRenderer(typeof(MyFrame), typeof(MyFrameRenderer))]
namespace MEDU.Droid
{
	public class MyFrameRenderer : FrameRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
		{
			base.OnElementChanged(e);
#pragma warning disable CS0618
			this.SetBackgroundDrawable(Resources.GetDrawable(Resource.Drawable.blue_rect));
#pragma warning restore CS0618
		}
	}
}

