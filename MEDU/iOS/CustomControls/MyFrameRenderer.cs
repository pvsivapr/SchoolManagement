using System;
using MEDU;
using MEDU.iOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using System.ComponentModel;
using CoreGraphics;
using UIKit;

[assembly: ExportRenderer(typeof(MyFrame), typeof(MyFrameRenderer))]

namespace MEDU.iOS
{
	public class MyFrameRenderer : FrameRenderer
	{
		protected override void OnElementChanged(ElementChangedEventArgs<Frame> e)
		{
			base.OnElementChanged(e);
			this.Layer.CornerRadius = 18;
			this.Layer.Bounds.Inset(1, 1);
			Layer.BorderColor = UIColor.White.CGColor;
			Layer.BorderWidth = 2;
			Layer.BackgroundColor = Color.Transparent.ToCGColor();
		}
	}
}