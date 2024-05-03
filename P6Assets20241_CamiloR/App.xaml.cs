using P6Assets20241_CamiloR.Views;

namespace P6Assets20241_CamiloR
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new LoginPage());
        }
    }
}
