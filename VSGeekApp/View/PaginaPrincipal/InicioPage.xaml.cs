using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VSGeekApp.Model.Response;
using VSGeekApp.ViewModel.PaginaApresentacao;

namespace VSGeekApp.View.PaginaPrincipal;

public partial class InicioPage : ContentPage
{
    private PaginaApresentacaoViewModel _vm;
    public InicioPage()
    {
        InitializeComponent();
        
        _vm = new PaginaApresentacaoViewModel();
        BindingContext = _vm;
    }

    private void BorderTiposProdutos_Tapped(object? sender, TappedEventArgs e)
    {
        Border border = (Border)sender;
        TiposProdutosResponse model = (TiposProdutosResponse)border.BindingContext;
        
        _vm.CliqueListaTiposProdutos(model);
    }
}