using System;
using Xamarin.Forms;

namespace loom.time
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()

		{
            BackgroundImage = "background.jpg";
            InitializeComponent ();
		}

		async void OnSignUpButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new SignUpPage ());
		}

		async void OnLoginButtonClicked (object sender, EventArgs e)
		{
			
            	App.IsUserLoggedIn = true;
				Navigation.InsertPageBefore (new Views.MainTabbedPage (), this);
				await Navigation.PopAsync ();
			
		}


	}
}
