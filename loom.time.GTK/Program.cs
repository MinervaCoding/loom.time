using System;
using System.Net;
using Xamarin.Forms;
using Xamarin.Forms.Platform.GTK;

namespace loom.time.GTK
{
    class MainClass
    {
        [STAThread]
        static void Main(string[] args)
        {
//            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            Gtk.Application.Init();
            Forms.Init();
            var app = new App();
            var window = new FormsWindow();
            window.LoadApplication(app);
            window.SetApplicationTitle("loom.time");
            window.Show();
            Gtk.Application.Run();
        }
    }
}
