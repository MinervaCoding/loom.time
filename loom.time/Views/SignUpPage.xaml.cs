using System;
using System.Linq;
using Xamarin.Forms;

namespace loom.time.Views
{
    public partial class SignUpPage : ContentPage
    {
        public SignUpPage()

        {
            //BackgroundImage = "background.jpg";
            InitializeComponent();

            fill_departmenet_data();

            }

        async void OnSignUpButtonClicked(object sender, EventArgs e)
        {

            //Hier den Test

        }

        private void fill_departmenet_data()
        {

            for (int i = 1; i < 5; i++)

                        {


                department.Items.Add("Beispiel Abteilung " + i);


            }



            /*
             * var department = new Picker { Title = "Select a department" };
            department.Items.Add("Baboon");
            department.Items.Add("Capuchin Monkey");
            department.Items.Add("Blue Monkey");
            department.Items.Add("Squirrel Monkey");
            department.Items.Add("Golden Lion Tamarin");
            department.Items.Add("Howler Monkey");
            department.Items.Add("Japanese Macaque");
            */
        }

    }
}
