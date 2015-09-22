using System;
using Xamarin.Forms;

namespace ToolbarColors
{
	public class HelloPage : ContentPage
	{
		public HelloPage ()
		{
			Content = new StackLayout {
				Children = {
					new Label {
						XAlign = TextAlignment.Center,
						Text = "Welcome to Xamarin Forms!"
					}
				},
				VerticalOptions = LayoutOptions.Center
			};
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			var random = new Random();
			var color = String.Format("#{0:X6}", random.Next(0x1000000));

			MessagingCenter.Send<HelloPage, string>(this, "Bar bg color", color);
		}
	}
}
