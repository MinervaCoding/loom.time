using Xamarin.Forms;

namespace loom.time.Views
{
    public class MainPageCS : TabbedPage
    {
        public MainPageCS()
        {


            Children.Add(new Login());

            Children.Add(new Date());

            Children.Add(new TimeAndPerfomance());
        }
    }
}
