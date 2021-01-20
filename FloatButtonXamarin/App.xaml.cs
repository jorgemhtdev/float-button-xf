namespace FloatButtonXamarin
{
    using Xamarin.Forms;

    public partial class App : Application
    {
        public App()
        {
            //Device.SetFlags(new string[] { "Expander_Experimental" });

            InitializeComponent();

            MainPage = new MainPage();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
