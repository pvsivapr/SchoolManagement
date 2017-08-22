﻿using System;
using Android.OS;
using System.Diagnostics;
using Xamarin.Forms;
using Android.Graphics;
using System.ComponentModel;
using MEDU;
using MEDU.Droid;
using Xamarin.Forms.Platform.Android;
using Android.Views;

[assembly: ExportRenderer(typeof(ImageCircle), typeof(ImageCircleRender))]

namespace MEDU.Droid
{
	public class ImageCircleRender : ImageRenderer
	{

		protected override void OnElementChanged(ElementChangedEventArgs<Image> e)
		{
			base.OnElementChanged(e);

			if (e.OldElement == null)
			{

				//if ((int)Android.OS.Build.VERSION.SdkInt < 18)
				//	SetLayerType (LayerType.Software, null);
			}
		}

		protected override bool DrawChild(Canvas canvas, global::Android.Views.View child, long drawingTime)
		{
			try
			{
				var radius = Math.Min(Width, Height) / 2;
				var strokeWidth = 10;
				radius -= strokeWidth / 2;


				Path path = new Path();
				path.AddCircle(Width / 2, Height / 2, radius, Path.Direction.Ccw);
				canvas.Save();
				canvas.ClipPath(path);

				var result = base.DrawChild(canvas, child, drawingTime);

				canvas.Restore();

				path = new Path();
				path.AddCircle(Width / 2, Height / 2, radius, Path.Direction.Ccw);

				var paint = new Paint();
				paint.AntiAlias = true;
				paint.StrokeWidth = 5;
				paint.SetStyle(Paint.Style.Stroke);
				paint.Color = global::Android.Graphics.Color.Blue;

				canvas.DrawPath(path, paint);

				paint.Dispose();
				path.Dispose();
				return result;
			}
			catch (Exception ex)
			{
				var msg = ex.Message;
			}

			return base.DrawChild(canvas, child, drawingTime);
		}

	}
}

