using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSGeekApp.View.CriarConta;

namespace VSGeekApp.View.PaginaPrincipal;

public partial class PerfilPage : ContentPage
{
    public PerfilPage()
    {
        InitializeComponent();
    }
    
    private async void CriarConta_Tapped(object? sender, TappedEventArgs e)
    {
        await Navigation.PushAsync(new CriarContaPage());
    }
}