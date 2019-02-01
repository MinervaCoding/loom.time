using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace loom.time
{
    public partial class UserLogin : ContentPage
    {
        public UserLogin()
        {
            InitializeComponent();
        }

        private void PressMeButton_Pressed(object sender, EventArgs e)
        {
            (sender as Button).Text = "You pressed me!";
        }

        private void PressMeButton_Clicked(object sender, EventArgs e)
        {
            (sender as Button).Text = "I was just clicked!";
        }

    }


    }
