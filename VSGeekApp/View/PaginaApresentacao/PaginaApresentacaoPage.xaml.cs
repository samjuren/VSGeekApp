using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSGeekApp.View.PaginaPrincipal;

namespace VSGeekApp.View.PaginaApresentacao;

public partial class PaginaApresentacaoPage : ContentPage
{
    public PaginaApresentacaoPage()
    {
        InitializeComponent();
    }

    private void Button_OnClicked(object? sender, EventArgs e)
    {
        Application.Current.MainPage = new NavigationPage(new PaginaPrincipalPage());
    }
}