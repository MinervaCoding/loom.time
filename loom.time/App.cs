using Xamarin.Forms;

namespace loom.time
{
	public class App : Application
	{
		public static bool IsUserLoggedIn { get; set; }

		public App ()
		{

			if (!IsUserLoggedIn) {
				MainPage = new NavigationPage (new Views.LoginPage ());
			} else {
				MainPage = new NavigationPage (new loom.time.Views.MainTabbedPage ());
			}
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}

