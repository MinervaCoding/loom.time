using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using SQLite;


namespace loom.time
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            // creating the db for testing purpose. should be placed in a controller
            var db = new LocalLoomDB(LocalLoomDB.DatabaseFilePath);

        }
    }
}
