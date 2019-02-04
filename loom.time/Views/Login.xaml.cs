using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace loom.time.Views
{
    public partial class Login : ContentPage
    {
        public Login()
        {
            BackgroundImage = "background.jpg";
            InitializeComponent();

            Entry EntryStaff;
            EntryStaff = new Entry { };
        }

        void Handle_Pressed(object sender, System.EventArgs e)
        {
            string nameValue = EntryStaff.Text;
            double dblENtry = Convert.ToDouble(EntryStaff.Text);

            ViewModels.VM_Login NewLogin = new ViewModels.VM_Login();

            bool CheckLogin = NewLogin.SetLogin(dblENtry);

            if (CheckLogin)  
                {
                // Erhält LoginNr
                int intStuffNumber = NewLogin.LoginNr;

                // Formatiert in string mit führenden Nullen "D4"
                EntryStaff.Text = intStuffNumber.ToString("D4");

                }
            else
                {

                EntryStaff.Text = "";
                EntryStaff.Placeholder = "Incorrect";

            }


        }
    }
}

