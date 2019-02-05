using System;
using Xamarin.Forms;

namespace loom.time.Views
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()

		{
            //BackgroundImage = "background.jpg";
            InitializeComponent ();
		}

		async void OnSignUpButtonClicked (object sender, EventArgs e)
		{
			await Navigation.PushAsync (new SignUpPage ());
		}

		async void OnLoginButtonClicked (object sender, EventArgs e)
		{



            string nameValue = EntryStaff.Text;
            double dblENtry = Convert.ToDouble(EntryStaff.Text);

            ViewModels.VM_Login NewLogin = new ViewModels.VM_Login();

            bool CheckLogin = NewLogin.SetLogin(dblENtry);



            if (CheckLogin)
            {
                // Erhält LoginNr
                int intStaffNumber = NewLogin.LoginNr;

                // Formatiert in string mit führenden Nullen "D4"
                EntryStaff.Text = intStaffNumber.ToString("D4");
                EntryStaff.TextColor = Color.Yellow;
                EntryStaff.IsEnabled = false;

                //Button lock
                LoginButton.Text = "loged in as";
                LoginButton.IsEnabled = false;

                //Hier Name Eintragen
                StaffName.Text = NewLogin.StaffName;
                //StaffName.Text = "Huber, Jakob";
                StaffName.IsVisible = true;
                StaffName.TextColor = Color.LightGray;


                App.IsUserLoggedIn = true;
                Navigation.InsertPageBefore(new Views.MainTabbedPage(), this);
                await Navigation.PopAsync();

            }
            else
            {

                EntryStaff.Text = "";
                EntryStaff.Placeholder = "Incorrect";

            }

        }


	}
}
