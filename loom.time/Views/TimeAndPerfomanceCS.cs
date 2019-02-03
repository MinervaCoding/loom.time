using Xamarin.Forms;

namespace loom.time.Views
{
    public class TimeAndPerfomanceCS : ContentPage
    {
        public TimeAndPerfomanceCS()
        {
            Icon = "settings.png";
            Title = "TimeAndPerfomance";
            Content = new StackLayout
            {
                Children = {
                    new Label {
                        Text = "TimeAndPerfomance go here",
                        HorizontalOptions = LayoutOptions.Center,
                        VerticalOptions = LayoutOptions.CenterAndExpand
                    }
                }
            };
        }
    }
}