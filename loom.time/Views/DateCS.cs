using Xamarin.Forms;

namespace loom.time.Views
{
    public class DateCS : ContentPage
    {
        public DateCS()
        {
            Icon = "settings.png";
            Title = "Date";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "Date go here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}