using VSGeekApp.View.PaginaApresentacao;
using VSGeekApp.View.PaginaPrincipal;
namespace VSGeekApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Application.Current.UserAppTheme = AppTheme.Dark;
            MainPage =  new NavigationPage(new PaginaApresentacaoPage());
        }
    }
}