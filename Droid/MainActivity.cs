using System;
using Android.App;
using Android.Content;
using Android.Content.PM;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using Android.Graphics.Drawables;

namespace ToolbarColors.Droid
{
	[Activity (Label = "ToolbarColors.Droid", Icon = "@drawable/icon", MainLauncher = true, ConfigurationChanges = ConfigChanges.ScreenSize | ConfigChanges.Orientation)]
	public class MainActivity : global::Xamarin.Forms.Platform.Android.FormsApplicationActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			global::Xamarin.Forms.Forms.Init (this, bundle);

			LoadApplication (new App ());

			ActionBar.SetIcon(Android.Resource.Color.Transparent);
			if ((int)Android.OS.Build.VERSION.SdkInt >= 21) {
				ActionBar.SetIcon (
					new ColorDrawable (Resources.GetColor (Android.Resource.Color.Transparent)));
			}
		}
	}
}
