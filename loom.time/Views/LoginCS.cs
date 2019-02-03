using Xamarin.Forms;

namespace loom.time.Views
{
    public class LoginCS : ContentPage
    {
        public LoginCS()
        {
            Icon = "settings.png";
            Title = "Login";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Login go here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}