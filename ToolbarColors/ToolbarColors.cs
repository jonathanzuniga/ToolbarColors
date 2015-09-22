using System;
using Xamarin.Forms;

namespace ToolbarColors
{
	public class App : Application
	{
		readonly Page tab1Page;
		readonly Page tab2Page;
		readonly Page tab3Page;

		public App ()
		{
			var tabbedPage = new TabbedPage { Title = "Hello!" };

			tab1Page = new HelloPage ();
			tab2Page = new HelloPage ();
			tab3Page = new HelloPage ();

			tabbedPage.Children.Add(tab1Page);
			tabbedPage.Children.Add(tab2Page);
			tabbedPage.Children.Add(tab3Page);

			var navigationPage = new NavigationPage(tabbedPage);

			MessagingCenter.Subscribe<HelloPage, string> (this, "Bar bg color", (page, color) => {
				DependencyService.Get<IChangeSBColor>().ChangeStatusBarColor(color);
				navigationPage.BarBackgroundColor = Color.FromHex (color);
			});
			navigationPage.BarTextColor = Color.FromHex ("#fff");

//			tabbedPage.CurrentPage = tab1Page;
//			if (tabbedPage.CurrentPage == tab2Page) {
//				navigationPage.BarBackgroundColor = Color.FromHex ("#f000");
//			}

			MainPage = navigationPage;
		}
	}
}
