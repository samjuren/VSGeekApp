using VSGeekApp.View.PaginaPrincipal;
namespace VSGeekApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage =  new NavigationPage(new PaginaPrincipalPage());
        }
    }
}