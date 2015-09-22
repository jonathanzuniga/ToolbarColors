using System;
using Xamarin.Forms;
using ToolbarColors.Droid;
using Android.OS;
using Android.Views;
using Android.App;

[assembly: Dependency (typeof (ChangeSBColor))]

namespace ToolbarColors.Droid
{
	public class ChangeSBColor : IChangeSBColor
	{
		public ChangeSBColor ()
		{
		}

		public void ChangeStatusBarColor (string colorHex)
		{
			if (colorHex.StartsWith("#"))
				colorHex = colorHex.Substring(1);

			if (colorHex.Length != 6) throw new Exception("Color not valid");

			int colorR = int.Parse(colorHex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber);
			int colorG = int.Parse(colorHex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber);
			int colorB = int.Parse(colorHex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber);

			if (Build.VERSION.SdkInt >= BuildVersionCodes.Lollipop) {
//				Window.ClearFlags(WindowManagerFlags.TranslucentStatus);
				(Forms.Context as Activity).Window.AddFlags(WindowManagerFlags.DrawsSystemBarBackgrounds);
				(Forms.Context as Activity).Window.SetStatusBarColor(Android.Graphics.Color.Rgb(colorR, colorG, colorB));
			}
		}

//		private Color FromHex(string colorHex)
//		{
//			if (colorHex.StartsWith("#"))
//				colorHex = colorHex.Substring(1);
//
//			if (colorHex.Length != 6)
//				throw new Exception("Color not valid");
//
//			return Color.FromRgb(
//				int.Parse(colorHex.Substring(0, 2), System.Globalization.NumberStyles.HexNumber),
//				int.Parse(colorHex.Substring(2, 2), System.Globalization.NumberStyles.HexNumber),
//				int.Parse(colorHex.Substring(4, 2), System.Globalization.NumberStyles.HexNumber));
//		}
	}
}
