using Xamarin.Forms;

namespace mcforms
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new mcformsPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
