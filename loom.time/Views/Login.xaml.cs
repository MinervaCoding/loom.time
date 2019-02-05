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

            //Erst andere Tabs unsichtbar machen
            //Views.Date.IsVisibleProperty false;


            Entry EntryStaff;
            EntryStaff = new Entry { };


            //to delete
            //Label StaffName;
            //Label StaffName = new Label;

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

                //Andere Tabs sichtbar machen



            }
            else
                {

                EntryStaff.Text = "";
                EntryStaff.Placeholder = "Incorrect";

            }


        }
    }


}

